using Common.Communication;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Domain;
using System.Globalization;

namespace FrmLogin.GuiController
{
    public class AddGUIController
    {
        private static AddGUIController instance;
        public static AddGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddGUIController();
                }
                return instance;
            }
        }
        private AddGUIController()
        {
        }


        private UclaniDete forma;
     

        internal void Add(Dete dete)
        {

            Response response = Communication.Instance.Add(dete);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Sistem je zapamtio podatke o detetu!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekcija \n" + response.Exception.ToString());
                Environment.Exit(0);
            }
        }
    }
}
