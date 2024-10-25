using Common.Communication;
using Common.Domain;
using FrmLogin.GuiController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public class ZakazaniTreninziGUIController
    {

        private static ZakazaniTreninziGUIController instance;
        public static ZakazaniTreninziGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZakazaniTreninziGUIController();
                }
                return instance;
            }
        }
        private ZakazaniTreninziGUIController()
        {
        }


     //   private UclaniDete forma;



        internal List<Termin> zakazaniTreninzi(Termin termin)
        {

            Response response = Communication.Instance.ZakazaniTreninzi(termin);
            if (response.Exception == null && response.Result != null)
            {
                return (List<Termin>)response.Result;
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
                return null;
            }
        }
    }
}
