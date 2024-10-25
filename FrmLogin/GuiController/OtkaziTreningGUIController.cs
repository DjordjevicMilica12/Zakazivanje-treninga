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
    public class OtkaziTreningGUIController
    {
        private static OtkaziTreningGUIController instance;
        public static OtkaziTreningGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OtkaziTreningGUIController();
                }
                return instance;
            }
        }
        private OtkaziTreningGUIController()
        {
        }

        internal void otkaziTrening(Termin selectedtermin)
        {
            Response response = Communication.Instance.OtkaziTrening(selectedtermin);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Uspesno ste otkazali trening!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);

            }
        }

        internal void otkaziTreningRoditelj(Termin termin)
        {
            Response response = Communication.Instance.OtkaziTreningRoditelj(termin);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Sistem je otkazao trening!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);

            }
        }
    }
}
