using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajIDPlanTreningaSO : SystemOperationBase
    {
        public List<int> id { get; set; }
        public int Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            //id = broker.getIDPlanTreninga();
            PlanTreninga pl=new PlanTreninga();
           id= getResult(broker.getAll(pl));    
           if(id!=null && id.Count>0) 
            {
            Result=id.Max();
            }

        }

        private List<int> getResult(List<IEntity> entities)
        {
            List<int> tipovi = new List<int>();
            foreach (IEntity ent in entities)
            {
                int id = ((PlanTreninga)ent).id;
                tipovi.Add(id);
            }
            return tipovi;
        }
    }
}
