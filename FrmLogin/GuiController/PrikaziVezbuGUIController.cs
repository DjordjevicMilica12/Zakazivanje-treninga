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
    public class PrikaziVezbuGUIController
    {

        private static PrikaziVezbuGUIController instance;
        public static PrikaziVezbuGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PrikaziVezbuGUIController();
                }
                return instance;
            }
        }
        private PrikaziVezbuGUIController()
        {
        }


        private UclaniDete forma;




        internal List<Vezbe> PrikaziVezbe(Termin t)
        {
            Response response = Communication.Instance.PrikaziVezbe(t);
            if (response.Exception == null)
            {
                if(response.Result != null)
                {
                return (List<Vezbe>)response.Result;
                }
                else
                {
                   
                    return null;
                }
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
