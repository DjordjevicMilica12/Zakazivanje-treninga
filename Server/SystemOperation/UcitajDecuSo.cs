using Common;
using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class UcitajDecuSo : SystemOperationBase
    {
        private Roditelj roditelj;
        public List<Dete> Result { get; set; }

        public UcitajDecuSo(Roditelj roditelj)
        {
            this.roditelj = roditelj;
        }
        protected override void ExecuteConcreteOperation()
        {
            Dete dete = new Dete();
            dete.roditelj = roditelj;
            //dete.roditelj.id = roditelj.id;
            dete.JoinValues = "*";
            dete.JoinCondition = $"where roditeljID={roditelj.id}";
            Result = getResult(broker.getAllWithCondition(dete));
        }

        private List<Dete> getResult(List<IEntity> entities)
        {
         //   if (entities.Count == 0) return null;
            List<Dete> tip = new List<Dete>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Dete)ent);
            }
            return tip;
        }
    }
}
