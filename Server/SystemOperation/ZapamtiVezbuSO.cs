using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ZapamtiVezbuSO:SystemOperationBase
    {
        private Vezbe vezba;
     //   public int odg { get; set; }
        public ZapamtiVezbuSO(Vezbe vezba)
        {
            this.vezba = vezba;
        }
        protected override void ExecuteConcreteOperation()
        {
            // odg = broker.ubaciVezbu(vezba);
            
            broker.Add(vezba);

        }
    }
}
