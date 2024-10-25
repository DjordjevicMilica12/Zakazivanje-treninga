using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class ObrisiDatumSO:SystemOperationBase
    {
        private Termin datum;
        public int odg { get; set; }
        public ObrisiDatumSO(Termin datum)
        {
            this.datum = datum;
        }
        protected override void ExecuteConcreteOperation()
        {
            datum.UpdateValues = $"datumiVreme='{datum.datumIVreme}'";
            broker.Delete(datum);
        }
    }
}
