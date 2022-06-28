using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HW11_6.InputClass;
using SimpleCMenu.Menu;

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
            employer.GetClientsInfo();
            Console.ReadKey();
        }
        public static void MItemAddNewRecord()
        {
            Client client = new Client();
            FIO fio = new FIO();
            Console.WriteLine("Добавляем новую запись.");
            fio.FirstName = Input<string>("Введите имя клиента", );
            fio.LastName = Input<string>("Введите фамилию клиента", );
            fio.MiddleName = Input<string>("Введите отчество клиента", );
            client.Fio = fio;
            client.PhoneNum = Input<string>("Введите телефон", );
            client.PasportNum = Input<string>("Введите паспорт", );
            (employer as Manager).GetClientInfo(client);

            string K = (Input<string>("Вы подтверждаете данные?  Y или Д - для подтверждения, любой символ для отказа!")).ToUpper();

            if (!(K == "Y" || K == "Д")) return;
            (employer as Manager).AddClient(client);
        }
        public static void MItemChangePhoneNumber()
        {

        }
        public static void MItemChangePasportNumber()
        {

        }

        public static void MItemChangeLastName()
        {

        }
        public static void MItemChangeFirstName()
        {

        }
        public static void MItemChangeMiddleName()
        {

        }
        public static void MItemChangeWife()
        {
            Console.WriteLine("ЗОЧЕМ?");
            Thread.Sleep(2000);
            mainMenu.showMenu();
        }
    }
}

