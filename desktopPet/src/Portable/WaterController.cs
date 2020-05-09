using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPet
{
    public class WaterController
    {

        private string sqlCon;

        public WaterController()
        {
            sqlCon = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
        }

        public void AddWater(int waterValue)
        {
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();

                string sql = @"INSERT INTO WaterLog (DateTime, Ounces) VALUES (GETDATE(),@Value)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Value", waterValue);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException exception)
                    {
                        Console.WriteLine(exception.Message.ToString());
                    }
                }

                con.Close();
            }
        }

        public int GetTotalWaterDrank()
        {
            int totalWaterDrank = 0;
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();

                string sql = @"SELECT SUM(Ounces) as totalWaterDrank FROM WaterLog";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (!(reader["totalWaterDrank"] is DBNull))
                            {
                                totalWaterDrank = Convert.ToInt32(reader["totalWaterDrank"]);
                            }
                        }
                    }
                }

                con.Close();
            }
            return totalWaterDrank;
        }
    }
}
