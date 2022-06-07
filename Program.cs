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

            Consultant consultant = new Consultant("basa.json");


            Console.ReadKey();
            


        }

        
    }
}
