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
    public class UbaciVezbuGUIController
    {
        private static UbaciVezbuGUIController instance;
        public static UbaciVezbuGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UbaciVezbuGUIController();
                }
                return instance;
            }
        }
        private UbaciVezbuGUIController()
        {
        }


   /*     internal void AddDate(Termin termin)
        {

            Response response = Communication.Instance.AddDate(termin);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Uspesno ste dodali datum!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
            }
        }
   */

        internal void UbaciVezbu(Vezbe vezbe)
        {
            Response response = Communication.Instance.UbaciVezbu(vezbe);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Sistem je zapamtio podatke o vezbi!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
            }
        }
    }
}
