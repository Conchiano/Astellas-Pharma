using System;
using MySql.Data;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Astellas_Pharma
{
    public partial class FrmWelcome : Form
    {

        private Thread thread;

        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFrmLogin()
        {
            Application.Run(new FrmLogin());
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFrmRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFrmRegister()
        {
            Application.Run(new FrmRegister());
        }
    }
}
