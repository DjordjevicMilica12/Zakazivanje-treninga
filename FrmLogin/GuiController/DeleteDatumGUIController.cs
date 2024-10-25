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
    public class DeleteDatumGUIController
    {
        private static DeleteDatumGUIController instance;
        public static DeleteDatumGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteDatumGUIController();
                }
                return instance;
            }
        }
        private DeleteDatumGUIController()
        {
        }


        //  private UclaniDete forma;

       

        internal void DeleteDatum(Termin t)
        {
            Response response = Communication.Instance.DeleteDatum(t);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("Sistem je obrisao termin!");
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
            }
        }
    }
}
