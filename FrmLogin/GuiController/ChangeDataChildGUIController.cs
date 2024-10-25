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
    public class ChangeDataChildGUIController
    {
        private static ChangeDataChildGUIController instance;
        public static ChangeDataChildGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChangeDataChildGUIController();
                }
                return instance;
            }
        }
        private ChangeDataChildGUIController()
        {
        }


        private PromeniPodatkeDetetu forma;


        internal void Change(Dete dete)
        {

            Response response = Communication.Instance.ChangeDataForChild(dete);
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

        internal List<Dete> GetChildren(Roditelj roditelj)
        {
            Response response = Communication.Instance.GetChildren(roditelj);
            if (response.Exception == null && response.Result != null)
            {
                return (List<Dete>)response.Result;
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
                return (List<Dete>)response.Result;
            }
                
        }
    }
}
