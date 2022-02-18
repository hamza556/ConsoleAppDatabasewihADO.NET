using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @" server = DESKTOP-09G7IAL; database =  CoffeeShop; integrated security = SSPI ";

            SqlConnection con = new SqlConnection(cs);


            //string Bname = string.Empty;
            //string Cname = string.Empty;
            //string price;
            //DateTime dattime;
            //Bname = Console.ReadLine();
            //Cname = Console.ReadLine();
            //price = Console.ReadLine();
            //dattime = Convert.ToDateTime(Console.ReadLine());

            //string query = "insert into Coffee values('" + Bname + "','" + Cname + "'," + price + ",'" + dattime + "')";
            //con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            //command.ExecuteNonQuery();
            //con.Close();
            //Console.WriteLine("Records Inserted Successfully");

            // retriving  record 
            SqlCommand command1 = new SqlCommand("SELECT STRING_AGG(BrandName, ',') FROM Coffee WHERE BrandName LIKE '%abc%';", con);
            con.Open();
            SqlDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0}", reader.GetString(0));
            }

            con.Close();
            Console.ReadLine();
     
        }
    }
}
