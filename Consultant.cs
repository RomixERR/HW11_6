using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW11_6
{
    internal class Consultant : EmployerBankA , IConsultant
    {
        public Consultant (string pathFileName): base (pathFileName) {}

        public override string GetClientInfo(int NumberOfClient)
        {
            if (NumberOfClient > GetClientsCount()) return $"Клиета {NumberOfClient} не существует";
            return $"{clients[NumberOfClient].Fio}\n" +
                   $"{clients[NumberOfClient].PhoneNum}\t" +
                   $"****-********";
        }

        public void SetPhoneNum(int NumberOfClient, string phoneNum)
        {
            if (NumberOfClient > GetClientsCount()) return;
            if (String.IsNullOrEmpty(phoneNum)) return;
            clients[NumberOfClient].PhoneNum = phoneNum;
        }
    }
}
