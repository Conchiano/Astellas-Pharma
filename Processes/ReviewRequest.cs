using Astellas_Pharma.Entities;
using Astellas_Pharma.Processes;
using MySqlX.XDevAPI.CRUD;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Windows.Forms;

namespace Astellas_Pharma
{
    class ReviewRequest:Database
    {
        private RDoc rDoc;

        public ReviewRequest(RDoc rDoc)
        {
            this.rDoc = rDoc;
        }

        // inserting a new Row in the table RDoc

        public void MakeReviewRequest()
        {
            InsertNewRDocInTableRDoc();
            InsertAllEntriesInRDocSpecialisms();
        }

        private void InsertNewRDocInTableRDoc()
        {
            string sqlQuery;
            sqlQuery = "INSERT INTO rdocs(title, link, authorId) VALUES ('" + rDoc.Title + "', '" + rDoc.Link + "', " + rDoc.AuthorId + ");"; //TODO
            Create(sqlQuery);
        }

        private void InsertAllEntriesInRDocSpecialisms()
        {
            string sqlQuery;
            DataTable dt = rDoc.SpecialismWithMinGrade;
            int rdocId = GetLastRDocId();
            int minGrade;
            foreach (DataRow dr in dt.Rows)
            {
                minGrade = Convert.ToInt32(dr.ItemArray[1].ToString());
                sqlQuery = "Insert Into rdocspecialisms values (" + rdocId + ",'" + dr.ItemArray[0].ToString() + "'," + minGrade + ")";
                Create(sqlQuery);
            }
        }
        public int GetLastRDocId()
        {
            int rdocId;
            string sqlQuery = "Select rdocid from rdocs order by rdocId desc limit 1";
            rdocId = GetInteger(sqlQuery);
            return rdocId;
        }
    }
}
