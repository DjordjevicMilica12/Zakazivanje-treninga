using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class VratiProgrameSO:SystemOperationBase
    {
        public List<Common.Domain.Program> programi { get; set; }

        private readonly Common.Domain.Program pr = new Common.Domain.Program();
        protected override void ExecuteConcreteOperation()
        {
            //  programi = broker.vratiPrograme();
            programi = GetResult(broker.getAll(pr));
        }

        public List<Common.Domain.Program> GetResult(List<IEntity> lista)
        {
            List<Common.Domain.Program> tipovi = new List<Common.Domain.Program>();
            foreach (IEntity ent in lista)
            {
                tipovi.Add((Common.Domain.Program)ent);
            }
            return tipovi;
        }

    }
}
