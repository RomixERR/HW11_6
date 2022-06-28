using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client client1 = new Client(new FIO { FirstName = "fn1", LastName = "Жоподряблов", MiddleName = "mn1" }, "+799656555", "1804-2222222");
            //Client client2 = new Client(new FIO { FirstName = "fn2", LastName = "Киргофов", MiddleName = "mn2" }, "+799656556", "1804-2222223");

            //Consultant consultant = new Consultant("basa.json");
            //Console.WriteLine(consultant.GetClientsCount());
            //Console.WriteLine(consultant.GetClientInfo(0));

            //Manager manager = new Manager("basa.json");
            //manager.AddClient();
            //manager.AddClient(client1);
            //manager.AddClient(client2);
            //manager.SetPhoneNum(3, "zzzzzzzzzz");

            Consultant consultant = new Consultant("basa.json");
            //consultant.SetPhoneNum(1, "fffff");

            Console.WriteLine(consultant.GetClientsInfo());

            Console.ReadKey();
            


        }

        
    }
}
