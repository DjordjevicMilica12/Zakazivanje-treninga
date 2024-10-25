using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GuiController
{
    public class DecaZakazaniTreninziGUIController
    {

        private static DecaZakazaniTreninziGUIController instance;
        public static DecaZakazaniTreninziGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DecaZakazaniTreninziGUIController();
                }
                return instance;
            }
        }
        private DecaZakazaniTreninziGUIController()
        {
        }


        //   private UclaniDete forma;



        internal List<Termin> zakazaniTreninziDeca(Roditelj roditelj)
        {

            Response response = Communication.Instance.DecaZakazaniTreninzi(roditelj);
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
