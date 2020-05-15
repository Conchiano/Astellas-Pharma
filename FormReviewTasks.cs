using System;
using Astellas_Pharma.Processes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astellas_Pharma
{
    public partial class FrmReviewTasks : Form
    {
        private int reviewerId;
        ReviewTaskExtractor reviewTaskExtractor;

        public FrmReviewTasks(int reviewerId)
        {
            InitializeComponent();

            this.reviewerId = reviewerId;
            reviewTaskExtractor = new ReviewTaskExtractor(reviewerId);
        }

        private void FrmReviewTasks_Load(object sender, EventArgs e)
        {
            SetInvisibleAllPanels1();

            DataTable dTableAllStatus = reviewTaskExtractor.GetReviewsAllStatus();
            dGridStatusAll.DataSource = dTableAllStatus;

            DataTable dTableAwaitingStatus = reviewTaskExtractor.GetReviewsAwaiting();
            dGridStatusAwaiting.DataSource = dTableAwaitingStatus;

            DataTable dTableOpenStatus = reviewTaskExtractor.GetReviewsOpen();
            dGridStatusOpen.DataSource = dTableOpenStatus;

            DataTable dTableLockedStatus = reviewTaskExtractor.GetReviewsLocked();
            dGridStatusLocked.DataSource = dTableLockedStatus;

            DataTable dTableClosedStatus = reviewTaskExtractor.GetReviewsClosed();
            dGridStatusClosed.DataSource = dTableClosedStatus;
        }

        private void SetInvisibleAllPanels1()
        {
            pnlComments.Visible = false;
        }

        private void dGridStatusAwaiting_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlComments.Visible = true;
        }



    }
}
