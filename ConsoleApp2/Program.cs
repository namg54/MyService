using ConsoleApp2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Sample For Create Generic Queue
            TestClass tc1 = new TestClass();
            tc1.Id = 1; tc1.Name = "a";
            TestClass tc2 = new TestClass();
            tc2.Id = 2; tc2.Name = "b";
            TestClass tc3 = new TestClass();
            tc3.Id = 3; tc3.Name = "c";
            TestClass tc4 = new TestClass();
            tc4.Id = 4; tc4.Name = "d";
            var queue = new Queue<TestClass>();
            queue.Enqueue(tc1);
            queue.Enqueue(tc2);
            queue.Enqueue(tc3);
            queue.Enqueue(tc4);
            foreach (var item in queue)
            {
                Console.WriteLine(item.Id + "/" + item.Name);

            }
            queue.Clear();
            //Call WebService 
            TestServiceSoapClient client=new TestServiceSoapClient();
            client.queueTest();
        }
    }
}
