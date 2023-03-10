using LinqToDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Summary description for TestService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestService : System.Web.Services.WebService
    {
        [WebMethod]
        public void queueTest()
        {
            Thread.Sleep(10000);
            TransferTest1 t1 = new TransferTest1();
            List<TransferTest1> tt1 = new List<TransferTest1>();
            var queue = new Queue<TransferTest1>();
            using (SqlConnection connection = new SqlConnection("Data source=.;Initial Catalog=Test;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("select top(5) * from table_1 where id=1;update top (5)  table_1 set id=4 where id=1;", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> namet1 = new List<string>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        t1.Id = (int)reader["ID"];
                        t1.Name = (string)reader["Name"];
                        tt1.Add(t1);
                        queue.Enqueue(t1);

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                //return tt1;
            }
            SqlConnection connection2 = new SqlConnection("Data source=.;Initial Catalog=Niloofartest;Integrated Security=True");
            if (tt1.Count != 0)
            {

                //for (int i = 0; i < tt1.Count; i++)
                //{
                foreach (var item in queue)
                {
                    //var x = tt1[i];
                    string query = "INSERT INTO Table_2 (id, name) VALUES(@id,@name)";
                    SqlCommand cmd = new SqlCommand(query, connection2);
                    cmd.Parameters.AddWithValue("id", item.Id);
                    cmd.Parameters.AddWithValue("name", item.Name);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            queue.Clear();

            }

        }
    }
}
