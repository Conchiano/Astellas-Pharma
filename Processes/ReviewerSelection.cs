using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Threading.Tasks;

namespace Astellas_Pharma.Processes
{
    class ReviewerSelection : Database
    {
        private int authorId;
        private int rDocId;

        public ReviewerSelection(int rDocId, int authorId)
        {
            this.rDocId = rDocId;
            this.authorId = authorId;
        }

        public void CreateReview()
        {
            GetAllReviewersWithSpecialismWithoutOverload();
        }

        private void GetAllReviewersWithSpecialismWithoutOverload()
        {
            string specialism;
            int minGrade;
            DataTable dtAllSpecialismWithMinGradeForAnRDoc;
            DataTable dt = new DataTable();
            dtAllSpecialismWithMinGradeForAnRDoc = GetAllReviewRequestsForAnRDoc();

            foreach (DataRow dr in dtAllSpecialismWithMinGradeForAnRDoc.Rows)
            {
                specialism = dr.ItemArray[0].ToString();
                minGrade = Convert.ToInt32(dr.ItemArray[1].ToString());
                dt = GetListOfReviewersWithSpecialism(specialism, minGrade);
                CreateReviewsForAnRDoc(dt);
            }


        }

        private void CreateReviewsForAnRDoc(DataTable dt)
        {
            Boolean isReviewerNotOverload;
            int reviewerId;
            string specialism;
            string sqlQuery;

            foreach (DataRow dr in dt.Rows)
            {
                reviewerId = Convert.ToInt32(dr.ItemArray[0].ToString());
                specialism = dr.ItemArray[1].ToString();
               // Console.WriteLine(" The specialism is " + specialism);
                isReviewerNotOverload = CheckReviewerNotOverload(reviewerId);

                if (isReviewerNotOverload)
                {
                    sqlQuery = "INSERT INTO reviews (rDocId, specialism, reviewerId) VALUES" +
                        "(" + rDocId + ",' " + specialism + " '," + reviewerId + ");";

                    Create(sqlQuery);
                }
            }
        }


        private Boolean CheckReviewerNotOverload(int reviewerId)
        {
            Boolean isReviewerNotOveroad;
            int count;
            string sqlQuery = "SELECT count(reviewId) FROM reviews WHERE reviewerId = " +reviewerId+ " AND status = 'awaiting';";
            count = GetInteger(sqlQuery);
           // Console.WriteLine("Count of Reviewer " + reviewerId + "is " + count);
            isReviewerNotOveroad = (count < 3) ? true : false;
            return isReviewerNotOveroad;
        }

        private DataTable GetAllReviewRequestsForAnRDoc()
        {
            DataTable dt;
            string sqlQuery = "SELECT specialism, minGrade from rdocspecialisms WHERE rDocId = " + rDocId + ";";
            dt = Read(sqlQuery);
          //  Console.WriteLine("GetAllReviewRequestsForAnRDoc");

            return dt;
        }

        private DataTable GetListOfReviewersWithSpecialism(string sp, int minGrade)
        {
            string sqlQuery = "select reviewerId, specialism from reviewerspecialisms " +
                "where specialism ='" + sp + "' and average>= " + minGrade + " and NOT reviewerId  = " + authorId + "; ";
            DataTable dt = Read(sqlQuery);
          // Console.WriteLine("GetListOfReviewersWithSpecialism");

            return dt;
        }
    }
}
