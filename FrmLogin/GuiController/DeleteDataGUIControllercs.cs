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
    public class DeleteDataGUIControllercs
    {

        private static DeleteDataGUIControllercs instance;
        public static DeleteDataGUIControllercs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteDataGUIControllercs();
                }
                return instance;
            }
        }
        private DeleteDataGUIControllercs()
        {
        }



        internal List<Termin> GetDate(Trener trener)
        {
            Response response = Communication.Instance.getDate(trener);
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
