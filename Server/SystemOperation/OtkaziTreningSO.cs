using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class OtkaziTreningSO : SystemOperationBase
    {
        private Termin termin;
      
        public OtkaziTreningSO(Termin termin)
        {
            this.termin = termin;
        }
        protected override void ExecuteConcreteOperation()
        {           
             
            if(termin.trener==null)
            {
            //ako je roditelj prijavljen
            termin.UpdateValues = $"slobodan='TRUE', planTreningaID=NULL";
            termin.UpdateCondition = $"datumIVreme='{termin.datumIVreme}'";
            broker.Update(termin);
            }
            else
            {
            //ako je trener prijavljen
            termin.UpdateValues = $"datumiVreme='{termin.datumIVreme}'";
            broker.Delete(termin);
            }
            otkaziSveVezbe(termin.planTreninga);
            otkaziTreningUPlanuTreninga(termin.planTreninga);
        }

        private void otkaziTreningUPlanuTreninga(PlanTreninga planTreninga)
        {
            planTreninga.UpdateValues = $"idPlanTreninga={planTreninga.id}";
            broker.Delete(planTreninga);
        }

        private void otkaziSveVezbe(PlanTreninga plan)
        {
            Vezbe v= new Vezbe();
            v.planTreninga = plan;
            v.UpdateValues = $"planTreningaID={plan.id}";
            broker.Delete(v);   
        }
    }
}
