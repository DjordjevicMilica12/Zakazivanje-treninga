using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class RezervisiTreningSO : SystemOperationBase
    {
        private Termin termin;

        public RezervisiTreningSO(Termin termin)
        {
            this.termin = termin;
        }

        public int odg { get; set; }
      
        protected override void ExecuteConcreteOperation()
        {
            // odg = broker.reserveTraining(termin);
            PlanTreninga pl = termin.planTreninga;
            broker.Add(pl);
            Rezervacija(termin);
        }

        private void Rezervacija(Termin termin)
        {
            termin.UpdateValues = $"slobodan='FALSE', planTreningaID={termin.planTreninga.id}";
            termin.UpdateCondition = $"datumIVreme = '{termin.datumIVreme}'";
            broker.Update(termin);
        }
    }
}
