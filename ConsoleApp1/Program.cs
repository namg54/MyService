using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ServiceReference1;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestServiceSoapClient soapClient = new TestServiceSoapClient();
            //TransferTest2 t2 = new TransferTest2();
            List<TransferTest1> t2 = new List<TransferTest1>(soapClient.queueTest().ToList());
            foreach ( var item in t2)
            {
                Console.WriteLine(item.Id + "/"+item.Name+"\n");
            }
            //Console.WriteLine(soapClient.queueTest());
            Console.ReadLine();
        }
    }
}
