using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class ObrisiDeteSO : SystemOperationBase
    {

        private Dete dete;
       // public int odg { get; set; }
        public ObrisiDeteSO(Dete dete)
        {
            this.dete = dete;
        }
        protected override void ExecuteConcreteOperation()
        {
            dete.UpdateValues=$"idDete={dete.id}";
            broker.Delete(dete);
        }
    }
}
