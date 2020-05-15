using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astellas_Pharma.Processes
{
    class ReviewTaskExtractor : Database
    {
        int reviewerId;
        public ReviewTaskExtractor(int reviewerId)
        {
            this.reviewerId = reviewerId;
            Console.WriteLine("The Reviewer Id is " + reviewerId);
        }

        public DataTable GetReviewsAllStatus()
        {
            string sqlQuery = "SELECT rv.reviewId, rd.title, rd.link, rv.status FROM reviews rv INNER JOIN rdocs rd WHERE rv.rdocId = rd.rdocId AND rv.reviewerId = " + reviewerId + ";";
           
            return Read(sqlQuery);
        }

        public DataTable GetReviewsAwaiting()
        {
            string sqlQuery = "select rv.reviewId, rd.title, rd.link, rv.specialism, rv.status from reviews rv inner join rdocs rd where rv.status ='Awaiting' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";

            return Read(sqlQuery);
        }

        public DataTable GetReviewsOpen()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd where rv.status ='Open' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";

            return Read(sqlQuery);
        }

        public DataTable GetReviewsLocked()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd where rv.status ='Locked' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";

            return Read(sqlQuery);
        }

        public DataTable GetReviewsClosed()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd where rv.status ='Closed' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";

            return Read(sqlQuery);
        }
    }
}
