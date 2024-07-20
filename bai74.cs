using System;
using System.Data.SqlClient;

namespace Database_Operation
{
    class InsertStatement
    {
        static void Main()
        {
            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO demo (ID, Name) VALUES (@id, @name)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@id", 3);
                        cmd.Parameters.AddWithValue("@name", "Python");

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
