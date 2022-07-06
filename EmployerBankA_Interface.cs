using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeUsersLite;

namespace HW11_6
{
    internal abstract partial class EmployerBankA
    {
        protected void SetPhoneNumRet(int NumberOfClient, string phoneNum)
        {
            if (NumberOfClient > GetClientsCount()) return;
            if (String.IsNullOrEmpty(phoneNum)) return;
            clients[NumberOfClient].PhoneNum = phoneNum;
            ChangeAndSave(clients[NumberOfClient], this.ToString(), phoneNum, "phoneNum");
        }
        protected void SetNameRet(int NumberOfClient, string firstName, string lastName, string middleName)
        {
            clients[NumberOfClient].Fio = new FIO() { FirstName = firstName, LastName = lastName, MiddleName = middleName };
            ChangeAndSave(clients[NumberOfClient], this.ToString(), clients[NumberOfClient].Fio.ToString(), "Fio");
        }

        protected void SetLNameRet(int NumberOfClient, string lastName)
        {
            string firstName = clients[NumberOfClient].Fio.FirstName;
            //string lastName = clients[NumberOfClient].Fio.LastName;
            string middleName = clients[NumberOfClient].Fio.MiddleName;
            SetNameRet(NumberOfClient, firstName, lastName, middleName);
        }
        protected void SetFNameRet(int NumberOfClient, string firstName)
        {
            //string firstName = clients[NumberOfClient].Fio.FirstName;
            string lastName = clients[NumberOfClient].Fio.LastName;
            string middleName = clients[NumberOfClient].Fio.MiddleName;
            SetNameRet(NumberOfClient, firstName, lastName, middleName);
        }
        protected void SetMNameRet(int NumberOfClient, string middleName)
        {
            string firstName = clients[NumberOfClient].Fio.FirstName;
            string lastName = clients[NumberOfClient].Fio.LastName;
            //string middleName = clients[NumberOfClient].Fio.MiddleName;
            SetNameRet(NumberOfClient, firstName, lastName, middleName);
        }

        protected void SetPasportNumRet(int NumberOfClient, string pasportNum)
        {
            clients[NumberOfClient].PasportNum = pasportNum;
            ChangeAndSave(clients[NumberOfClient], this.ToString(), clients[NumberOfClient].PasportNum.ToString(), "pasportNum");
        }
        protected void AddClientRet(Client client)
        {
            clients.Add(client);
            ChangeAndSave(client, this.ToString(), client.Fio.FirstName, "Add new");
        }

        protected void AddClientRet()
        {
            FakeUser fakeUser = new FakeUser();
            Client client = new Client(new FIO { FirstName = fakeUser.GetFName(), LastName = fakeUser.GetLName(), MiddleName = fakeUser.GetMName() },
                fakeUser.GetPhone(),
                fakeUser.GetPasport()
                );
            AddClient(client);
        }
        /////////////
        private static string ExcMessage1 = "Недостаточно прав у пользователя";
        public virtual void SetPhoneNum(int NumberOfClient, string phoneNum) => throw new Exception(ExcMessage1);
        public virtual void SetName(int NumberOfClient, string firstName, string lastName, string middleName) => throw new Exception(ExcMessage1);
        public virtual void SetLName(int NumberOfClient, string lastName) => throw new Exception(ExcMessage1);
        public virtual void SetFName(int NumberOfClient, string firstName) => throw new Exception(ExcMessage1);
        public virtual void SetMName(int NumberOfClient, string middleName) => throw new Exception(ExcMessage1);
        public virtual void SetPasportNum(int NumberOfClient, string pasportNum) => throw new Exception(ExcMessage1);
        public virtual void AddClient(Client client) => throw new Exception(ExcMessage1);
        public virtual void AddClient() => throw new Exception(ExcMessage1);
    }

    internal interface IManager
    {
        void SetPhoneNum(int NumberOfClient, string phoneNum);
        void SetName(int NumberOfClient, string firstName, string lastName, string middleName);
        void SetLName(int NumberOfClient, string lastName);
        void SetFName(int NumberOfClient, string firstName);
        void SetMName(int NumberOfClient, string middleName);
        void SetPasportNum(int NumberOfClient, string pasportNum);
        void AddClient(Client client);
        void AddClient();
    }

    internal interface IConsultant
    {
        void SetPhoneNum(int NumberOfClient, string phoneNum);
    }
}
