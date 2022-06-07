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
            return clients[NumberOfClient].fio;
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
            List<Client> clients;
            try
            {
                StreamReader streamReader = new StreamReader(pathFileName);
                clients = (List<Client>)JsonConvert.DeserializeObject(streamReader.ReadToEnd(), typeof(List<Client>));
                streamReader.Close();
            }
            catch (Exception e) { return (false, e.Message); }
            return (true, "OK");
        }
        /// <summary>
        /// Сохраняет коллекцию клиентов в файл
        /// </summary>
        /// <param name="pathFileName"></param>
        /// <param name="clients"></param>
        /// <returns></returns>
        public (bool result, string error) SaveToFile()
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
        public abstract string GetClientInfo(int NumberOfClient);
    }

    internal interface IConsultant
    {
        void SetPhoneNum(int NumberOfClient, string phoneNum);
    }

    internal interface IManager
    {
        void SetName(int NumberOfClient, string firstName, string lastName, string middleName);
        void SetPasportNum(int NumberOfClient, string pasportNum);
    }
 
}
