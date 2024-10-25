using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {

        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public bool Connect()
        {
            /* socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
             socket.Connect("127.0.0.1", 9999);
             sender = new Sender(socket);
             receiver = new Receiver(socket);*/


            try
            {
                if(socket == null || !socket.Connected)
                {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                sender = new Sender(socket);
                receiver = new Receiver(socket);

                }
                return true;
            }
            catch (SocketException e)
            {
                Debug.WriteLine("<<<<" + e.Message);         
                return false;
            }
            
          
        }


        internal Response Login(Object osoba,Uloge u)
        {
            try {
                if (u == Uloge.roditelj)
                {
                    Request req = new Request
                    {
                        Argument = (Roditelj)osoba,
                        Operation = Operation.Login,
                        Uloga = "roditelj"
                    };
                    sender.Send(req);
                    Response response = (Response)receiver.Receive();
                    return response;
                }
                else
                {
                    Request req = new Request
                    {
                        Argument = (Trener)osoba,
                        Operation = Operation.Login,
                        Uloga = "trener"
                    };
                    sender.Send(req);
                    Response response = (Response)receiver.Receive();
                    return response;
                } }
            catch (IOException e)
            {
                Response response = new Response();
                response.Exception = e;
                return response;
            }
        }

        internal Response Add(Dete dete)
        {
            try
            {
                Request req = new Request
                {
                    Argument = dete,
                    Operation = Operation.Add
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
        }

    
        internal Response ChangeDataForChild(Dete dete)
        {

            try
            {
                Request req = new Request
                {
                    Argument = dete,
                    Operation = Operation.ChangeDataForChild
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }

        }

        internal Response GetChildren(Roditelj roditelj)
        {
            try
            {
                Request req = new Request
                {
                    Argument = roditelj,
                    Operation = Operation.GetChildren
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response Delete(Dete dete)
        {
            try
            {
                Request req = new Request
                {
                    Argument = dete,
                    Operation = Operation.deleteChild
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response DajTermin()
        {
            try
            {
                Request req = new Request
                {
                    //    Argument
                    Operation = Operation.getTermin
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response ZakaziTrening(Termin selectedtermin)
        {
            try
            {
                Request req = new Request
                {
                    Argument = selectedtermin,
                    Operation = Operation.reserveTraining
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response DajProgram()
        {
            try
            {
                Request req = new Request
                {
                    //    Argument
                    Operation = Operation.getProgram
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response vratiId()
        {
            try
            {
                Request req = new Request
                {
                    //    Argument
                    Operation = Operation.getIDPlanTreninga
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response LoginTrener(Trener trener)
        {
            try
            {
                Request req = new Request
                {
                    Argument = trener,
                    Operation = Operation.loginTrener
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response ZakazaniTreninzi(Termin termin)
        {
            try
            {
                Request req = new Request
                {
                    Argument = termin,
                    Operation = Operation.getTerminForCoach
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response AddDate(Termin termin)
        {
            try
            {
                Request req = new Request
                {
                    Argument = termin,
                    Operation = Operation.addDate
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response getDate(Trener trener)
        {
            try
            {
                Request req = new Request
                {
                    Argument = trener,
                    Operation = Operation.getDateForTrener
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response DeleteDatum(Termin termin)
        {
            try
            {
                Request req = new Request
                {
                    Argument = termin,
                    Operation = Operation.deleteDate
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response OtkaziTrening(object selectedtermin)
        {
            try
            {
                Request req = new Request
                {
                    Argument = selectedtermin,
                    Operation = Operation.otkaziTrening,
                   
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response vratiPrograme()
        {
            try
            {
                Request req = new Request
                {
                    //  Argument = selectedtermin,
                    Operation = Operation.vratiPrograme
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response UbaciVezbu(Vezbe vezbe)
        {
            try
            {
                Request req = new Request
                {
                    Argument = vezbe,
                    Operation = Operation.ubaciVezbu
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response PrikaziVezbe(Termin t)
        {
            try
            {
                Request req = new Request
                {
                    Argument = t,
                    Operation = Operation.prikaziVezbe
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response DecaZakazaniTreninzi(Roditelj roditelj)
        {
            try
            {
                Request req = new Request
                {
                    Argument = roditelj,
                    Operation = Operation.decaZakazaniTreninzi
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response DaLiPostojiDatum(Termin t)
        {

            try
            {
                Request req = new Request
                {
                    Argument = t,
                    Operation = Operation.daLiPostojiDatum
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }

        internal Response OtkaziTreningRoditelj(Termin termin)
        {

            try
            {
                Request req = new Request
                {
                    Argument = termin,
                    Operation = Operation.otkaziTreningRoditelj
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (SerializationException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                return response;
            }
            catch (IOException e)
            {

                Debug.WriteLine(e);
                Response response = new Response();
                response.Exception = e;
                response.isServerDown = true;
                return response;
            }
        }
    }
}
