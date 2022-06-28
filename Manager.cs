using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FakeUsersLite;

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
            ChangeAndSave(client, this.ToString(), client.Fio.FirstName, "Add new");
        }

        public void AddClient()
        {
            FakeUser fakeUser = new FakeUser();
            Client client = new Client(new FIO { FirstName = fakeUser.GetFName(), LastName = fakeUser.GetLName(), MiddleName = fakeUser.GetMName() },
                fakeUser.GetPhone(),
                fakeUser.GetPasport()
                );
            AddClient(client);
        }
        //public override string GetClientInfo(Client client)
        //{
        //    return $"{client.Fio}\n" +
        //          $"{client.PhoneNum}\t" +
        //          $"{client.PasportNum}";
        //}
        public override string GetClientInfo(Client client)
        {
            return $"Name:\t{client.Fio,-35}\t" +
                   $"Phone:\t{client.PhoneNum,-18}\t" +
                   $"Pasport:\t{client.PasportNum}";
        }

        public void SetName(int NumberOfClient, string firstName, string lastName, string middleName)
        {
            clients[NumberOfClient].Fio = new FIO() { FirstName=firstName, LastName = lastName, MiddleName = middleName};
            ChangeAndSave(clients[NumberOfClient], this.ToString(), clients[NumberOfClient].Fio.ToString(), "Fio");
        }

        public void SetPasportNum(int NumberOfClient, string pasportNum)
        {
            clients[NumberOfClient].PasportNum = pasportNum;
            ChangeAndSave(clients[NumberOfClient], this.ToString(), clients[NumberOfClient].PasportNum.ToString(), "pasportNum");
        }

        public override string ToString()
        {
            return "Менеджер";
        }

    }
}
