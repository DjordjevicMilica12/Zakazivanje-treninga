using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class DajTermineTrenerSo : SystemOperationBase
    {
        private Trener argument;
        //za brisanje slobodnih termina kod trenera
        public DajTermineTrenerSo(Trener argument)
        {
            this.argument = argument;
        }

        public List<Termin> datumi { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Termin t=new Termin();
            t.trener = argument;
            
            t.JoinValues = "*";
            t.JoinCondition = $"where trenerID={argument.id} and slobodan=1";

          //  datumi = broker.getAllWithCondition(termin);
            datumi = getResult(broker.getAllWithCondition(t));
        }

        private List<Termin> getResult(List<IEntity> entities)
        {
            //if (entities.Count == 0) return null;
            List<Termin> tip = new List<Termin>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Termin)ent);
            }
            return tip;
        }

    }
}
