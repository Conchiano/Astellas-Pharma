using Astellas_Pharma.Entities;
using Astellas_Pharma.Utilities;
using Astellas_Pharma.Processes;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Astellas_Pharma
{
    public partial class FrmMakeReviewRequest : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable("SelectedSpecialismWithMinGrade");
        ReviewRequest reviewRequest;
        ReviewerSelection reviewerSelection;
        protected Thread thread;
        private int userId;

        public FrmMakeReviewRequest()
        {
            InitializeComponent();
        }

        private void FrmMakeReviewRequest_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                ChkLstBxSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            DataColumn col;
            DataRow row;
            col = new DataColumn();
            panelminGrade.Visible = true;
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Specialism";
            dt.Columns.Add(col);
            col = new DataColumn();
            col.DataType = Type.GetType("System.Int32");
            col.ColumnName = "MinGrade";
            dt.Columns.Add(col);

            int noOfSpecialisms = ChkLstBxSpecialisms.CheckedItems.Count;

            int i = 0;
            foreach (var item in ChkLstBxSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialisms)
                {
                    row = dt.NewRow();
                    row["Specialism"] = item.ToString();
                    row["MinGrade"] = 5;
                    dt.Rows.Add(row);
                }
                i++;
            }
            dGridViewMinGrade.DataSource = dt;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            RDoc rDoc = new RDoc();
            int rdocId;
            rDoc.Title = TxtBxTitle.Text.Trim().ToLower();
            rDoc.Link = TxtBxLink.Text.Trim().ToLower();
            rDoc.AuthorId = 10; //TODO
            rDoc.SpecialismWithMinGrade = dt;
            reviewRequest = new ReviewRequest(rDoc);
            reviewRequest.MakeReviewRequest();
            rdocId = reviewRequest.GetLastRDocId();
            BtnSubmit.Enabled = false;
            reviewerSelection = new ReviewerSelection(rdocId, rDoc.AuthorId);
            reviewerSelection.CreateReview();

            //Load Dashboard
            this.Close();
            thread = new Thread(openfrmDashboard);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private void openfrmDashboard()
        {
            Application.Run(new frmDashboard(userId));
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openfrmDashboard);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
