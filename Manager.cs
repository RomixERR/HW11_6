using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW11_6
{
    internal class Manager : EmployerBankA, IManager
    {

        public Manager(string pathFileName) : base(pathFileName)
        {
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
            ChangeAndSave(client, this.GetType().Name, client.Fio.FirstName, "Add new");
        }

        public void AddClient()
        {
            Client client = new Client(new FIO { FirstName = "fn", LastName = "ln", MiddleName = "mn" },
                "8-800-555-2535",
                "1899-992299"
                );
            AddClient(client);
        }



        public override string GetClientInfo(Client client)
        {
            return $"{client.Fio}\n" +
                  $"{client.PhoneNum}\t" +
                  $"{client.PasportNum}";
        }

        public void SetName(int NumberOfClient, string firstName, string lastName, string middleName)
        {
            clients[NumberOfClient].Fio = new FIO() { FirstName=firstName, LastName = lastName, MiddleName = middleName};
            ChangeAndSave(clients[NumberOfClient], this.GetType().Name, clients[NumberOfClient].Fio.ToString(), "Fio");
        }

        public void SetPasportNum(int NumberOfClient, string pasportNum)
        {
            clients[NumberOfClient].PasportNum = pasportNum;
            ChangeAndSave(clients[NumberOfClient], this.GetType().Name, clients[NumberOfClient].PasportNum.ToString(), "pasportNum");
        }

 
    }
}
