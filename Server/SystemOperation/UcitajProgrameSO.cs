using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajProgrameSO : SystemOperationBase
    {
        public List<Common.Domain.Program> Result { get; set; }

        //kod zakazivanja treninga
        protected override void ExecuteConcreteOperation()
        {
            Common.Domain.Program rp = new Common.Domain.Program();
            Result = getResult(broker.getAll(rp));
        }

        private List<Common.Domain.Program> getResult(List<IEntity> entities)
        {
            List<Common.Domain.Program> tip = new List<Common.Domain.Program>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Common.Domain.Program)ent);
            }
            return tip;
        }
    }
}
