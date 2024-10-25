using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { broker = new Broker(); }

        public Object Login(Object osoba)
        {
            LoginSO so = new LoginSO(osoba);
            so.ExecuteTemplate();
            return so.Result;

        }

        internal int Add(Dete dete)
        {
         ZapamtiDeteSo add=new ZapamtiDeteSo(dete); 
         add.ExecuteTemplate();
            return add.odg;
        }

        internal List<Dete> GetChildren(Roditelj roditelj)
        {
            UcitajDecuSo get = new UcitajDecuSo(roditelj);
            get.ExecuteTemplate();
            return get.Result;
        }

        internal object ChangeDataForChild(Dete dete)
        {
            IzmeniPodatkeZaDeteSO udc = new IzmeniPodatkeZaDeteSO(dete);
            udc.ExecuteTemplate();
            return udc.odg;
        }

        internal void DeleteChild(Dete dete)
        {
            ObrisiDeteSO delete= new ObrisiDeteSO(dete);
            delete.ExecuteTemplate();   
           // return delete.odg;  
        }

        internal List<Termin> getTermin()
        {
            UcitajTermineSO termin= new UcitajTermineSO();
            termin.ExecuteTemplate();
            return termin.Result;
        }

        internal object ReserveTraining(Termin termin)
        {
            RezervisiTreningSO trening = new RezervisiTreningSO(termin);
            trening.ExecuteTemplate();
            return trening.odg; ;
        }


        internal object getProgram()
        {
           UcitajProgrameSO program= new UcitajProgrameSO();
            program.ExecuteTemplate();
            return program.Result;
        }

        internal object getIDPlanTreninga()
        {
            UcitajIDPlanTreningaSO id=new UcitajIDPlanTreningaSO();
            id.ExecuteTemplate();
            return id.Result;
        }


        internal List<Termin> getTerminForCoach(Termin termin)
        {
           UcitajRezervisaneTreningeSO terminForCoachSO = new UcitajRezervisaneTreningeSO(termin);
            terminForCoachSO.ExecuteTemplate(); 
            return terminForCoachSO.Result;
        }

        internal void addDate(Termin datum)
        {
            ZapamtiSlobodanTerminSo a = new ZapamtiSlobodanTerminSo(datum);
            a.ExecuteTemplate();
        }

        internal object getDateForTrener(Trener argument)
        {
            DajTermineTrenerSo getDate = new DajTermineTrenerSo(argument);
            getDate.ExecuteTemplate();
            return getDate.datumi;
        }

        internal void deleteDatum(Termin argument)
        {
            ObrisiDatumSO del=new ObrisiDatumSO(argument);  
            del.ExecuteTemplate();
            
        }

        internal void otkaziTrening(Termin argument)
        {
            OtkaziTreningSO ot = new OtkaziTreningSO(argument);
            ot.ExecuteTemplate();
        }

        internal object vratiPrograme()
        {
           VratiProgrameSO vrat= new VratiProgrameSO(); 
            vrat.ExecuteTemplate();
            return vrat.programi;
        }

        internal void ubaciVezbu(Vezbe argument)
        {
            ZapamtiVezbuSO ubaci = new ZapamtiVezbuSO(argument);
            ubaci.ExecuteTemplate();
            
        }

        internal object prikaziVezbe(Termin argument)
        {
            UcitajVezbeSO p = new UcitajVezbeSO(argument);
            p.ExecuteTemplate();
            return p.Result;
        }

        internal object decaZakazaniTreninzi(Roditelj argument)
        {
            VratiDecaZakazaniTreninziSO op = new VratiDecaZakazaniTreninziSO(argument);
            op.ExecuteTemplate();
            return op.deca;
        }

        internal object daLiPostojiDatum(Termin argument)
        {
            UcitajDatumDaLiPostojiSO po = new UcitajDatumDaLiPostojiSO(argument);
            po.ExecuteTemplate();
            return po.Result;
        }

      /*  internal void otkaziTreningRoditelj(Termin argument)
        {
            OtkaziTreningRoditeljSO ot = new OtkaziTreningRoditeljSO(argument);
            ot.ExecuteTemplate();
         
        }*/
    }
}
