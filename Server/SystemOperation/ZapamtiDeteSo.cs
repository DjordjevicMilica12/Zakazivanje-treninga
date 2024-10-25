using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class ZapamtiDeteSo : SystemOperationBase
    {
        private Dete dete;
        public int odg { get; set; }
        public ZapamtiDeteSo(Dete dete)
        {
            this.dete = dete;
        }
        protected override void ExecuteConcreteOperation()
        {
            dete.clanstvo = true;
           broker.Add(dete);
           
        }
    }
}
