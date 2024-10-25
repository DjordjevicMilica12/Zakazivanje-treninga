using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajTermineSO : SystemOperationBase
    {
        public List<Termin> Result { get; set; }
      
        protected override void ExecuteConcreteOperation()
        {
            Termin t= new Termin();
            t.JoinValues = $" t.idTermin, t.datumIVreme, d.ime,d.prezime,d.datumRodjenja, p.nazivPrograma, t.planTreningaID, t.trenerID, t.slobodan";
            t.JoinCondition = $"as t left JOIN PlanTreninga as pt on t.planTreningaID = pt.idPlanTreninga left join Dete as d on pt.deteID=d.idDete left join Program p on pt.programID=p.sifraPrograma where slobodan=1";
            Result = getResult(broker.getAllWithCondition(t));
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
