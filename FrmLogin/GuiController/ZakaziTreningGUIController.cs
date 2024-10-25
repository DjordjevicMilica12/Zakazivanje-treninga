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
    public class ZakaziTreningGUIController
    {
        private static ZakaziTreningGUIController instance;
        public static ZakaziTreningGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZakaziTreningGUIController();
                }
                return instance;
            }
        }
        private ZakaziTreningGUIController()
        {
        }



        internal List<Termin> DajTermin()
        {
            Response response = Communication.Instance.DajTermin();
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

        internal void ZakaziTrening(Termin selectedtermin)
        {
            Response response = Communication.Instance.ZakaziTrening(selectedtermin);
            if (response.Exception == null && response.Result != null)
            {
               MessageBox.Show("Uspesno ste zakazali trening!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);

            }
        }

        internal List<Common.Domain.Program> DajProgram()
        {
            Response response = Communication.Instance.DajProgram();
            if (response.Exception == null && response.Result != null)
            {
                return (List<Common.Domain.Program>)response.Result;
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
                return null;
            }
        }

        internal int vratiID()
        {
            Response response = Communication.Instance.vratiId();
            if (response.Exception == null && response.Result != null)
            {
                return (int)response.Result;
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
                return -1;
            }
        }
    }
}
