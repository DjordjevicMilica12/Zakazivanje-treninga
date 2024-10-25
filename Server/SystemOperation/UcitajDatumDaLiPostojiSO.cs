using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajDatumDaLiPostojiSO:SystemOperationBase
    {
        private Termin termin;

        public UcitajDatumDaLiPostojiSO(Termin termin)
        {
            this.termin = termin;
        }

        // public bool odg { get; set; }

        public List<Termin> Res { get; set; }
        public bool Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            //  odg = broker.DaLiDatumPostoji(argument);
            termin.JoinValues = "*";
            termin.JoinCondition = $"WHERE datumIVreme = '{termin.datumIVreme}'";
           Res=getResult(broker.getAllWithCondition(termin));
            if(Res!=null && Res.Count > 0)
            {
               Result = true;
            }
            else
            {
               Result = false;
            }
        }

        private List<Termin> getResult(List<IEntity> entities)
        {
            if (entities.Count == 0) return null; //pretvara se u false
            List<Termin> tip = new List<Termin>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Termin)ent);
            }
            return tip;
        }


    }
}
