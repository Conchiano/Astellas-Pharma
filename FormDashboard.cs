using Astellas_Pharma.Processes;
using System;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace Astellas_Pharma
{
    public partial class frmDashboard : Form
    {
        private Thread thread;
        private int userId;
        private string fullName;

        public frmDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void BtnRDocs_Click(object sender, EventArgs e)
        {
            this.Hide();
            thread = new Thread(openFrmMakeReviewRequest);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openFrmMakeReviewRequest()
        {
            Application.Run(new FrmMakeReviewRequest());
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            fullName = new Login(userId).GetFullName();
            this.LblFname.Text = "Welcome " + fullName;
        }
        private void BtnReviewTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            thread = new Thread(OpenFrmReviewTasks);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmReviewTasks()
        {
            Application.Run(new FrmReviewTasks(userId));
        }

    }
}
