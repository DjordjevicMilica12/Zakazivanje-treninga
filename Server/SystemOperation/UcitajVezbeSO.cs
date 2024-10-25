using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajVezbeSO:SystemOperationBase
    {
        private Termin argument;

        public UcitajVezbeSO(Termin argument)
        {
            this.argument = argument;
        }

        public List<Vezbe> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            // vezbe = broker.VratiVezbe(argument);
            Vezbe v = new Vezbe();
            v.JoinValues = "*";
            v.JoinCondition = $"where planTreningaID={argument.planTreninga.id}";
            Result= getResult(broker.getAllWithCondition(v));
        }

        private List<Vezbe> getResult(List<IEntity> entities)
        {
            if (entities.Count == 0) return null; //moze da ostane jer na klijentskoj strani nema uslov za null tako da je ovde ok!!
            List<Vezbe> tip = new List<Vezbe>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Vezbe)ent);
            }
            return tip;
        }
    }
}
