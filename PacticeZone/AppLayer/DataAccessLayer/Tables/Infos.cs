using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using System.Data.SqlClient;

namespace DataAccessLayer.Tables
{
    public class Infos
    {
        public List<Info> Get()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\C#\PacticeZone\AppLayer\ArchDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "select * from INFO";
            SqlCommand cmd = new SqlCommand(query, con);

            List<Info> data = new List<Info>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Info temp = new Info();
                temp.Name = reader.GetString(reader.GetOrdinal("Name"));
               temp.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                temp.Course = reader.GetString(reader.GetOrdinal("Course"));

                data.Add(temp);
            }
            return data;
            
        }
        void add()
        {
            //inserting to DB
        }
        void delete()
        {
            //deleting from DB
        }
        void update()
        {
            // updating  
        }
    }
}
