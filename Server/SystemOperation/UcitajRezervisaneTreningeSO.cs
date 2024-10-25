using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajRezervisaneTreningeSO : SystemOperationBase
    {
        private Termin termin;

        public UcitajRezervisaneTreningeSO(Termin termin)
        {
            this.termin = termin;
        }

        public List<Termin> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {  
           
            termin.JoinValues = "d.*, t.*,p.*";
            
            termin.JoinCondition = $"as t JOIN PlanTreninga as pt on t.planTreningaID = pt.idPlanTreninga join Dete as d on pt.deteID=d.idDete join Program p on pt.programID=p.sifraPrograma where T.trenerID = {termin.trener.id} AND T.slobodan = 0";
            Result = getResult(broker.getAllWithCondition(termin));
        }

        private List<Termin> getResult(List<IEntity> termins)
        {
            List<Termin> tip = new List<Termin>();
            foreach (IEntity ent in termins)
            {
                tip.Add((Termin)ent);
            }
            return tip;
        }
    }
}
