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
    public class LoginGUIController
    {


        private static LoginGUIController instance;
        public static LoginGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGUIController();
                }
                return instance;
            }
        }
        private LoginGUIController()
        {
        }

        private Login formaLogin;
        internal void ShowFrmLogin()
        {
          //  Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaLogin = new Login();
            formaLogin.AutoSize = true;
            Application.Run(formaLogin);
        }


        public void Login(object sender, EventArgs e, Uloge u)
        {
            if (Communication.Instance.Connect())
            {

                if (u == Uloge.roditelj)
                {
                    Roditelj roditelj = new Roditelj
                    {
                        username = formaLogin.txtUsername.Text,
                        password = formaLogin.txtPassword.Text,
                    };

                    Response response = Communication.Instance.Login(roditelj,u);
                    if (response.Exception == null && response.Result != null)
                    {
                        formaLogin.Visible = false;
                        MainCoordinator.Instance.ShowFrmMain(response);
                    }
                    else
                    {
                        MessageBox.Show("Neuspеšan login");
                    }
                }
                else
                {
                    Trener trener = new Trener
                    {
                        username = formaLogin.txtUsername.Text,
                        password = formaLogin.txtPassword.Text,
                    };

                    Response response = Communication.Instance.Login(trener,u);
                    if (response.Exception == null && response.Result != null)
                    {
                        formaLogin.Visible = false;
                        MainCoordinator.Instance.ShowFrmMainTrener(response);
                    }
                    else
                    {
                        MessageBox.Show("Neuspеšan login.");
                    }
                }
            }
            else
            {
                MessageBox.Show("nije uspesna konekcija sa serverom");
            }
        }

        internal void LoginTrener(object sender, EventArgs e)
        {
            if (Communication.Instance.Connect())
            {
                Trener trener = new Trener
                {
                    username = formaLogin.txtUsername.Text,
                    password = formaLogin.txtPassword.Text,
                };

                Response response = Communication.Instance.LoginTrener(trener);
                if (response.Exception == null && response.Result != null)
                {
                    formaLogin.Visible = false;
                    MainCoordinator.Instance.ShowFrmMainTrener(response);
                }
                else
                {
                    MessageBox.Show("Proverite podatke! Korisnik nije u bazi.");
                }
            }
            else
            {
                MessageBox.Show("nije uspesna konekcija sa serverom");
            }
        }
    }
}
