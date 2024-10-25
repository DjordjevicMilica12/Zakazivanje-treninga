using Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

      /*  private MainCoordinator()
        {
            personGuiController = new PersonGuiController();
        }

        private FrmMain frmMain;
        private PersonGuiController personGuiController;
      */



        internal void ShowFrmMain(Response response)
        {
          FrmPocetnaRoditelj frmPocetna = new FrmPocetnaRoditelj(response);
            frmPocetna.Show();
        }

        internal void ShowFrmMainTrener(Response response)
        {
            FrmPocetnaTrener frmPocetna = new FrmPocetnaTrener(response);
            frmPocetna.Show();
        }





    }
}
