using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ZapamtiSlobodanTerminSo : SystemOperationBase
    {

        private Termin datum;
        
        public ZapamtiSlobodanTerminSo(Termin datum)
        {
            this.datum = datum;
        }


        protected override void ExecuteConcreteOperation()
        {
            datum.slobodan = true;
            datum.planTreninga = null;
            broker.Add(datum);

        }
    }
}
