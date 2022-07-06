using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW11_6
{
    internal class Consultant : EmployerBankA, IConsultant
    {
        public Consultant (string pathFileName): base (pathFileName) {}
        public override string GetClientInfo(Client client)
        {
            return  $"Name:\t{client.Fio,-35}\t" +
                    $"Phone:\t{client.PhoneNum,-18}\t" +
                    $"Pasport:\t****-******";
        }
        public override string ToString() => "Консультант";
        public override void SetPhoneNum(int NumberOfClient, string phoneNum) => base.SetPhoneNumRet(NumberOfClient, phoneNum);

        public override List<Client> GetClients()
        {
            List<Client> newCl = new List<Client>(Filter());
            foreach (Client item in newCl)
            {
                item.PasportNum = "****-******";
            }
            return newCl;
        }
    }
}
