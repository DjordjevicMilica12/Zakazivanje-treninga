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
    // mislim da nije ni sa cim povezano proveri..

    public class GetAllProgramsGUIController
    {

        private static GetAllProgramsGUIController instance;
        public static GetAllProgramsGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GetAllProgramsGUIController();
                }
                return instance;
            }
        }
        private GetAllProgramsGUIController()
        {
        }


        //  private UclaniDete forma;


        internal List<Common.Domain.Program> vratiPrograme()
        {
            Response response = Communication.Instance.vratiPrograme();
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
    }
}
