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
        public Manager(string pathFileName) : base(pathFileName)  {}
        public override string GetClientInfo(Client client)
        {
            return $"Name:\t{client.Fio,-35}\t" +
                   $"Phone:\t{client.PhoneNum,-18}\t" +
                   $"Pasport:\t{client.PasportNum}";
        }
        public override string ToString() => "Менеджер";
        public override void AddClient(Client client) => base.AddClientRet(client);
        public override void AddClient() => base.AddClientRet();
        public override void SetFName(int NumberOfClient, string firstName) => base.SetFNameRet(NumberOfClient, firstName);
        public override void SetLName(int NumberOfClient, string lastName) => base.SetLNameRet(NumberOfClient, lastName);
        public override void SetMName(int NumberOfClient, string middleName) => base.SetMNameRet(NumberOfClient, middleName);
        public override void SetName(int NumberOfClient, string firstName, string lastName, string middleName) => base.SetNameRet(NumberOfClient, firstName, lastName, middleName);
        public override void SetPasportNum(int NumberOfClient, string pasportNum) => base.SetPasportNumRet(NumberOfClient, pasportNum);
        public override void SetPhoneNum(int NumberOfClient, string phoneNum) => base.SetPhoneNumRet(NumberOfClient, phoneNum);

        public override List<Client> GetClients()
        {
            List<Client> newCl = new List<Client>(Filter());
            return newCl;
        }
    }
}
