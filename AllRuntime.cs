using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HW11_6.InputClass;
using SimpleCMenu.Menu;
using FakeUsersLite;

namespace HW11_6
{
    internal partial class Program
    {
        public static void MItemKonsult()
        {
            employer = new Consultant(pathFileName);
            MainMenu();
        }
        public static void MItemManager()
        {
            employer = new Manager(pathFileName);
            MainMenu();
        }
        public static void MItemExit()
        {
            Environment.Exit(0);
        }

        public static void MItemPrint()
        {
            Console.WriteLine(employer.GetClientsInfo());
            Console.ReadKey();
        }
        public static void MItemAddNewRecord()
        {
            Client client = new Client();
            FIO fio = new FIO();
            Console.WriteLine("Добавляем новую запись.");
            fio.FirstName = Input<string>("Введите имя клиента", fakeUser.GetFName());
            fio.LastName = Input<string>("Введите фамилию клиента", fakeUser.GetLName());
            fio.MiddleName = Input<string>("Введите отчество клиента", fakeUser.GetMName());
            client.Fio = fio;
            client.PhoneNum = Input<string>("Введите телефон", fakeUser.GetPhone());
            client.PasportNum = Input<string>("Введите паспорт", fakeUser.GetPasport());
            employer.GetClientInfo(client);

            string K = (Input<string>("Вы подтверждаете данные?  Y или Д - для подтверждения, любой символ для отказа!")).ToUpper();

            if (!(K == "Y" || K == "Д")) return;
            employer.AddClient(client);
        }
        public static void MItemChangePhoneNumber()
        {
            ChangeClientStringData(employer,  employer.SetPhoneNum , "Введите новый номер телефона", fakeUser.GetPhone());
        }
       
        public static void MItemChangePasportNumber()
        {
            ChangeClientStringData(employer, employer.SetPasportNum, "Введите новый номер паспорта", fakeUser.GetPasport());
        }

        public static void MItemChangeLastName()
        {
            ChangeClientStringData(employer, employer.SetLName, "Введите новую фамилию", fakeUser.GetLName());
        }
        public static void MItemChangeFirstName()
        {
            ChangeClientStringData(employer, employer.SetFName, "Введите новое имя", fakeUser.GetFName());
        }
        public static void MItemChangeMiddleName()
        {
            ChangeClientStringData(employer, employer.SetMName, "Введите новое отечество", fakeUser.GetMName());
        }

        public static void MItemChangeWife()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("ЗОЧЕМ?");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("ЗОЧЕМ??");
            Console.Beep();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            mainMenu.showMenu();
        }
        private static void ChangeClientStringData(EmployerBankA employer, Action<int, string> employerAction, string message, string fakeData)
        {
            int N = Input<int>("Введите порядковый номер клиента");
            var K = employer.GetClientInfo(N);
            Console.WriteLine(K.outString);
            if (K.isExist)
            {
                Console.WriteLine("Введите 0 для отмены ввода.");
                string PN = Input<string>(message, fakeData);
                if (PN == "0") return;
                employerAction(N, PN);
            }
            else { Console.ReadKey(); }
        }
    }
}

