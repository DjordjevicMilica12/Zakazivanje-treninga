using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiDecaZakazaniTreninziSO:SystemOperationBase
    {

        private Roditelj roditelj;
        public List<Termin> deca { get; set; }

        public VratiDecaZakazaniTreninziSO(Roditelj roditelj)
        {
            this.roditelj = roditelj;
        }
        protected override void ExecuteConcreteOperation()
        {
            //deca = broker.vratiDecuZakazaniTreninzi(roditelj);
            //Dete d= new Dete();
            //d.roditelj= roditelj;   
            Termin termin = new Termin();
            termin.planTreninga=new PlanTreninga();
            termin.planTreninga.dete=new Dete();    
            termin.planTreninga.dete.roditelj=roditelj;


            termin.JoinValues = "d.*, pt.*, t.*, p.*";
            termin.JoinCondition = $" as t join PlanTreninga as pt on t.planTreningaID=pt.idPlanTreninga  join Dete d on d.idDete=pt.deteID join Program p on p.sifraPrograma=pt.programID where d.roditeljID={termin.planTreninga.dete.roditelj.id}";
            deca=getResult(broker.getAllWithCondition(termin));
           
        }


        private List<Termin> getResult(List<IEntity> entities)
        {
            List<Termin> tip = new List<Termin>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Termin)ent);
           
            }
            return tip;
        }

    }
}
