using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO:SystemOperationBase
    {
        private readonly Object osoba;

        public Object Result { get; set; }
        public LoginSO(Object osoba)
        {
            
            this.osoba = osoba;
           
        }

        protected override void ExecuteConcreteOperation()
        {
            if (osoba is Trener)
            {
                Trener trener = (Trener)osoba;
                trener.JoinValues = "*";
                trener.JoinCondition = $"where username = '{trener.username}' and password = '{trener.password}'";
              Result= getResultTrener(broker.getAllWithCondition(trener));
            }
            else if (osoba is Roditelj)
            {
                Roditelj roditelj = (Roditelj)osoba;
                roditelj.JoinValues = "*";
                roditelj.JoinCondition = $"where username = '{roditelj.username}' and password = '{roditelj.password}'";
               Result=getResultRoditelj(broker.getAllWithCondition(roditelj));
            }
        /*    broker.Login(osoba);
            if (osoba.ime != null)
            {
            Result=osoba;
            }
            else
            {
            Result= null;
            }*/
        }

        private List<Trener> getResultTrener(List<IEntity> entities)
        {

            if (entities.Count == 0) return null;
            List<Trener> tip = new List<Trener>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Trener)ent);
            }
            return tip;
        }

        private List<Roditelj> getResultRoditelj(List<IEntity> entities)
        {
            if (entities.Count == 0) return null;
            List<Roditelj> tip = new List<Roditelj>();
            foreach (IEntity ent in entities)
            {
                tip.Add((Roditelj)ent);
            }
            return tip;
        }
    }
}
