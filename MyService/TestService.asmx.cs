using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
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
        public List<TransferTest1> queueTest()
        {
            #region New Ado.net

            //SqlConnection con = new SqlConnection("Data source=.;Initial Catalog=Niloofartest;Integrated Security=True");
            //SqlCommand query1 = new SqlCommand("select * from table_1 where id=1;update top (2)  table_1 set id=4",con);

            ////SqlCommand cmd = new SqlCommand(query1, con);
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataSet ds = new DataSet();
            //con.Open();
            //da.SelectCommand =query1;

            //da.Fill(ds);
            TransferTest1 t1 = new TransferTest1();
            using (SqlConnection connection = new SqlConnection("Data source=.;Initial Catalog=Niloofartest;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("select top(5) * from table_1 where id=1;update top (2)  table_1 set id=4 where id=1;",connection);

                //
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<TransferTest1> tt1=new List<TransferTest1>();
                List<string> namet1=new List<string>();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                       

                        t1.Id = (int)reader["ID"];
                        t1.Name= (string)reader["Name"];
                        tt1.Add(t1);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                
                SqlDataReader reader2 ;
                //SqlCommand command2 =new SqlCommand(query,connection);
                foreach (var item in tt1)
                {
                string query = "INSERT INTO Table_2 (id, name) VALUES("+item.Id+","+item.Name+")";
                    SqlCommand command2=new SqlCommand(query,connection);
                    reader2 =command2.ExecuteReader();
                    reader2.Close();
                }
                


                return tt1;

            }
           

            return null;

            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();

            //con.Close();

            #endregion






























            #region ADOdotnet
            //    string name;
            //    int id;
            //    //Queue queueTest = new Queue();
            //    //Console.WriteLine(queueTest.Count);
            //    while (true)
            //    {
            //        //System.Threading.Thread.Sleep(1 * 20 * 1000);

            //        int counter = 1;
            //        using (SqlConnection connection = new SqlConnection("Data source=.;Initial Catalog=Niloofartest;Integrated Security=True"))
            //        {
            //            try
            //            {


            //                string query1 = "select top (2) * from table_1 where id=1;update top (2)  table_1 set id=4";


            //                SqlCommand cmd = new SqlCommand(query1, connection);
            //                connection.Open();
            //                SqlDataReader reader;
            //                reader = cmd.ExecuteReader();
            //                //Queue queueTest = new Queue();
            //                if (reader.Read())
            //                {

            //                    for (int i = 0; i < reader.FieldCount; i++)
            //                    {
            //                        id = (int)reader[0];
            //                        name = reader[1].ToString();
            //                        string query2 = "Insert Into Table_2(id,name)Values(" + id + "," + name + ")";
            //                        cmd = new SqlCommand(query2, connection);
            //                        reader.Close();
            //                        cmd.ExecuteReader();
            //                    }
            //                }


            //                //for (int i = 0; i <= queueTest.Count; i++)
            //                //{
            //                //    string query2 = "Insert Into Table_2(id,name)Values(" + queueTest. + ",'a')";
            //                //    cmd = new SqlCommand(query2, connection);
            //                //    cmd.ExecuteReader();
            //                //}

            //                //cmd.ExecuteNonQuery();

            //                Console.WriteLine($"added{counter}");

            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Faild");

            //                throw;
            //            }



            //        }
            //    }

            //    return null;
            //}



            #endregion

        }
    }
}
