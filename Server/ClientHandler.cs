using Common;
using Common.Communication;
using Common.Domain;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;
        public ClientHandler(Socket klijentskiSoket)
        {
            this.socket = klijentskiSoket;
            sender = new Sender(klijentskiSoket);
            receiver = new Receiver(klijentskiSoket);
        }

        internal void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    Response r = ProcessRequest(req);
                    sender.Send(r);
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine(e.Message);

            }
        }

        internal void ZaustaviKlijente()
        {
            socket.Shutdown(SocketShutdown.Both); //da se isprazne svi tokovi
            socket.Close();

        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        if (req.Uloga == "roditelj")
                        {
                        r.Result = Controller.Instance.Login((Roditelj)req.Argument);
                        }
                        else
                        {
                        r.Result = Controller.Instance.Login((Trener)req.Argument);
                        }
                        if(r.Result == null)
                        {
                            r.Exception = new Exception("korisnik nije u bazi");
                        }
                        break;
                    case Operation.Add:
                        Controller.Instance.Add((Dete)req.Argument);
                        r.Result = 1;
                        break;
                    case Operation.GetChildren:
                        r.Result = Controller.Instance.GetChildren((Roditelj)req.Argument);
                        break;
                    case Operation.ChangeDataForChild:
                        r.Result = Controller.Instance.ChangeDataForChild((Dete)req.Argument);
                        break;
                    case Operation.deleteChild:
                        Controller.Instance.DeleteChild((Dete)req.Argument);
                        r.Result = 1;
                        break;
                    case Operation.getTermin:
                        r.Result = Controller.Instance.getTermin();
                        break;
                    case Operation.reserveTraining:
                        r.Result = Controller.Instance.ReserveTraining((Termin)req.Argument);
                        break;
                    case Operation.getProgram:
                        r.Result = Controller.Instance.getProgram();
                        break;
                    case Operation.getIDPlanTreninga:
                        r.Result = Controller.Instance.getIDPlanTreninga();
                        break;
                    case Operation.getTerminForCoach:
                        r.Result = Controller.Instance.getTerminForCoach((Termin)req.Argument);
                        break;
                    case Operation.addDate:
                         Controller.Instance.addDate((Termin)req.Argument);
                        r.Result = 1;
                        break;
                    case Operation.getDateForTrener:
                        r.Result = Controller.Instance.getDateForTrener((Trener)req.Argument);
                        break;
                    case Operation.deleteDate:
                        Controller.Instance.deleteDatum((Termin)req.Argument);
                        r.Result = 1;
                        break;
                    case Operation.otkaziTrening:
                        Controller.Instance.otkaziTrening((Termin)req.Argument);
                        r.Result = 1;
                        break;
                    case Operation.vratiPrograme:
                        r.Result = Controller.Instance.vratiPrograme(); //mislim da nije ni sa cim povezano
                        break;
                    case Operation.ubaciVezbu:
                         Controller.Instance.ubaciVezbu((Vezbe)req.Argument);
                        r.Result = 1;   
                        break;
                    case Operation.prikaziVezbe:
                        r.Result = Controller.Instance.prikaziVezbe((Termin)req.Argument);
                        break;
                    case Operation.decaZakazaniTreninzi:
                        r.Result = Controller.Instance.decaZakazaniTreninzi((Roditelj)req.Argument);
                        break;
                    case Operation.daLiPostojiDatum:
                        r.Result=Controller.Instance.daLiPostojiDatum((Termin)req.Argument);
                        break;
                  /*  case Operation.otkaziTreningRoditelj:
                        Controller.Instance.otkaziTreningRoditelj((Termin)req.Argument);
                        r.Result = 1;
                        break;*/
                }
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return r;
        }



    }





}
