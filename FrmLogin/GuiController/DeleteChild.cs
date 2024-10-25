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
    public class DeleteChild
    {
        private static DeleteChild instance;
        public static DeleteChild Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteChild();
                }
                return instance;
            }
        }
        private DeleteChild()
        {
        }


        private UclaniDete forma;


        internal void deleteChild(Dete dete)
        {

            Response response = Communication.Instance.Delete(dete);
            if (response.Exception == null && response.Result != null)
            {
                MessageBox.Show("SIstem je otkazao clanstvo detetu "+dete.ime + " "+ dete.prezime);
            }
            else
            {
                MessageBox.Show(">>> Prekinuta je konekacija!" + response.Exception.ToString());
                Environment.Exit(0);
            }
        }
    }
}
