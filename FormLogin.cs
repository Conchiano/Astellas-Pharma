using System;
using System.Threading;
using System.Windows.Forms;
//adding Libraries
using Astellas_Pharma.Processes;

namespace Astellas_Pharma
{
    public partial class FrmLogin : Form
    {

        protected Thread thread;
        int userId;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBxusername.Text.Trim().ToLower();
            string password = txtBxPassword.Text;
            Login logIn = new Login(username, password);
            if (logIn.Authenticate())
            {
                //The Credentials are correct
                userId = logIn.GetUserId();

                //Load Dashboard
                this.Close();
                thread = new Thread(openfrmDashboard);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

            else
            {
                //Send Messagebox
                MessageBox.Show("You are not a Registered User, Please Register!");
            }

        }

        private void openfrmDashboard()
        {
            Application.Run(new frmDashboard(userId));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
