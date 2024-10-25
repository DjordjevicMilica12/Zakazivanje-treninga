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
    public class AddDateGUIController
    {
        private static AddDateGUIController instance;
        public static AddDateGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddDateGUIController();
                }
                return instance;
            }
        }
        private AddDateGUIController()
        {
        }


      //  private UclaniDete forma;

        internal void AddDate(Termin termin)
        {

            Response response = Communication.Instance.AddDate(termin);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Sistem je zapamtio slobodan termin!");
            }
            else
            {
                MessageBox.Show(">>>" + response.Exception.ToString());
            }
        }

        internal bool DaLiPostojiDatum(Termin t)
        {
            Response response = Communication.Instance.DaLiPostojiDatum(t);
            if (response.Exception == null && response.Result != null)
            {
                return (bool)response.Result;
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
                return false;
            }
        }
    }
}
