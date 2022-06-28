using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW11_6
{
    internal class Consultant : EmployerBankA
    {
        public Consultant (string pathFileName): base (pathFileName) {}


        public override string GetClientInfo(Client client)
        {
            return $"{client.Fio}\n" +
                  $"{client.PhoneNum}\t" +
                  $"****-********";
        }
        public override string ToString()
        {
            return "Консультант";
        }

 
    }
}
