using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Server.SystemOperation
{
    public class IzmeniPodatkeZaDeteSO : SystemOperationBase
    {

        private Dete dete;
        public int odg { get; set; }
        public IzmeniPodatkeZaDeteSO(Dete dete)
        {
            this.dete = dete;
        }
        protected override void ExecuteConcreteOperation()
        {
            // odg = broker.changeDataForChild(dete);
            dete.UpdateValues = $"ime='{dete.ime}', prezime='{dete.prezime}', datumRodjenja='{dete.datumRodjenja}'";
            dete.UpdateCondition = $"idDete = {dete.id}";
            broker.Update(dete);
        }

    }
}
