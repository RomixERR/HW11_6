using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HW11_6
{
    internal abstract class EmployerBankA
    {
        protected List<Client> clients;
        protected string pathFileName;
        public int GetClientsCount()
        {
            return clients.Count;
        }
        public FIO GetClientFio(int NumberOfClient)
        {
            return clients[NumberOfClient].Fio;
        }
        public EmployerBankA(string pathFileName)
        {
            this.pathFileName = pathFileName;
            var R = LoadFromFile();
            if(!R.result || clients == null)
            {
                Console.WriteLine($"Загрузка БД не выполнена. Ошибка {R.error}, будет создана пустая БД");
                clients = new List<Client>();
            }
            else
            {
                Console.WriteLine($"Загрузка БД выполнена! БД Содержит {clients.Count} записей.");
            }
        }
        /// <summary>
        /// Выполняет загрузку коллекции клиентов из файла
        /// </summary>
        /// <param name="pathFileName">Путь к файлу или / и его имя</param>
        /// <returns></returns>
        public (bool result, string error) LoadFromFile()
        {
            clients = new List<Client>();
            try
            {
                StreamReader streamReader = new StreamReader(pathFileName);
                clients = (List<Client>)JsonConvert.DeserializeObject(streamReader.ReadToEnd(), typeof(List<Client>));
                streamReader.Close();

            }
            catch (Exception e) { return (false, e.Message); }
            return (true, "OK");
        }

        protected void ChangeAndSave(Client client, string WhoIsChange, string WhatDataIsChange, string TypeDataChange)
        {
            DateTime dateTime = DateTime.Now;
            client.WhoIsChange = WhoIsChange;
            client.WhatDataIsChange = WhatDataIsChange;
            client.dateTime = dateTime;
            client.TypeDataChange = TypeDataChange;
            SaveToFile();
        }
  
        /// <summary>
        /// Сохраняет коллекцию клиентов в файл
        /// </summary>
        /// <param name="pathFileName"></param>
        /// <param name="clients"></param>
        /// <returns></returns>
        protected (bool result, string error) SaveToFile()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(pathFileName);
                streamWriter.Write(JsonConvert.SerializeObject(clients, Formatting.Indented));
                streamWriter.Close();
            }
            catch (Exception e) { return (false, e.Message); }
            return (true, "OK");
        }
 

        public void SetPhoneNum(int NumberOfClient, string phoneNum)
        {
            if (NumberOfClient > GetClientsCount()) return;
            if (String.IsNullOrEmpty(phoneNum)) return;
            clients[NumberOfClient].PhoneNum = phoneNum;
            ChangeAndSave(clients[NumberOfClient], this.ToString(), phoneNum, "phoneNum");
        }

        public string GetClientInfo(int NumberOfClient)
        {
            if (NumberOfClient > GetClientsCount()) return $"Клиета {NumberOfClient} не существует";
            return GetClientInfo(clients[NumberOfClient]);
        }
        public abstract string GetClientInfo(Client client);
        public string GetClientsInfo()
        {
            string result = string.Empty;
            foreach (var item in clients)
	        {
                result += GetClientInfo(item) + "\n";
	        }
            return result;
        }
    }



    internal interface IManager
    {
        void SetName(int NumberOfClient, string firstName, string lastName, string middleName);
        void SetPasportNum(int NumberOfClient, string pasportNum);
        void AddClient(Client client);
    }
 
}
