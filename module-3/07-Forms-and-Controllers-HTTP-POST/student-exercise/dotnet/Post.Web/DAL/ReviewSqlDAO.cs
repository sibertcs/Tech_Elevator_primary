using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", conn);
                    

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reviews.Add(MapRowToActor(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return reviews;
        }
        private Review MapRowToActor(SqlDataReader reader)
        {
            return new Review()
            {
                UserName = Convert.ToString(reader["username"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                ReviewContent = Convert.ToString(reader["review_text"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"])
            };
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public void SaveReview(Review newReview)
        {
            try
            {

                using (var conn = new SqlConnection(connectionString))
                {

                    conn.Open();

                    var sql = $"INSERT INTO reviews VALUES (@userName, @rating, @reviewTitle, @reviewText, @reviewDate)";
                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userName", newReview.UserName);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@reviewTitle", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@reviewText", newReview.ReviewContent);
                    cmd.Parameters.AddWithValue("@reviewDate", DateTime.Now);

                    // Execute the command
                    var reader = cmd.ExecuteNonQuery();


                }
            }
            catch (SqlException ex)
            {
                throw;
            }

        }
    }
}
