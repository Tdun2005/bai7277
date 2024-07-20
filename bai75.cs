using System;
using System.Data.SqlClient;

namespace Database_Operation
{
    class UpdateStatement
    {
        // Main Method
        static void Main()
        {
            Update();
            Console.ReadKey();
        }

        static void Update()
        {
            string constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE demo SET articleName = @name WHERE articleID = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@name", "django");
                        cmd.Parameters.AddWithValue("@id", 3);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
