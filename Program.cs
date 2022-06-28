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
        const string pathFileName = "basa.json";
        static EmployerBankA employer;
        static ConsoleMenu firstMenu = new ConsoleMenu();
        static ConsoleMenu mainMenu = new ConsoleMenu();
        static void Main(string[] args)
        {
            firstMenu.SubTitle = "Выберете пользователя";
            firstMenu.addMenuItem(0, "Консультант", MItemKonsult);
            firstMenu.addMenuItem(1, "Менеджер", MItemManager);
            firstMenu.addMenuItem(2, "Выход",MItemExit);
            firstMenu.showMenu();



            //int P = Input<int>("Выберете пользователя: Консультант = 1, Менеджер = 2, Выход = 0 (или пустой ввод)", 0 );
            //if (P == 1)
            //{
            //    employer = new Consultant(pathFileName);
            //}
            //else if (P == 2)
            //{
            //    employer = new Manager(pathFileName);
            //}
            //else return;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("====Меню====");
            //    Console.WriteLine($"Вы зашли под [{employer}]");
            //    Console.WriteLine("============");
            //    Console.WriteLine("0 - выход");
            //    Console.WriteLine("1 - вывести данные на экран");
            //    Console.WriteLine("2 - добавить новую запись");
            //    Console.WriteLine("3 - изменить Фамилию");
            //    Console.WriteLine("4 - изменить Имя");
            //    Console.WriteLine("5 - изменить Отчество");
            //    Console.WriteLine("6 - изменить Телефон");
            //    Console.WriteLine("7 - изменить жене");
            //    Console.WriteLine("8 - изменить Номер паспорта");

            //    P = Input<int>();
            //    if (P == 0) break;
            //}

            //Console.WriteLine("Спасибо за использование программы нашего банка!");
            //Thread.Sleep(2000);
        }

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
        public static void MainMenu()
        {
            mainMenu.SubTitle = $"==== Меню =================\n" +
                                $"Вы зашли под [{employer}]\n" +
                                $"===========================";
            mainMenu.addMenuItem(0, "вывести данные на экран", MItemPrint);
            mainMenu.addMenuItem(1, "добавить новую запись", MItemAddNewRecord);
            mainMenu.addMenuItem(1, "изменить Телефон", );
            mainMenu.addMenuItem(1, "изменить Номер паспорта", );
            mainMenu.addMenuItem(1, "изменить Фамилию", );
            mainMenu.addMenuItem(1, "изменить Имя", );
            mainMenu.addMenuItem(1, "изменить Отчество", );
            mainMenu.addMenuItem(1, "изменить жене", );
            mainMenu.showMenu();
        }
        public static void MItemPrint()
        {
            Console.WriteLine("ывести данны");
            Thread.Sleep(2000);
        }
        public static void MItemAddNewRecord()
        {
            Console.WriteLine("бавить новую зап");
            Thread.Sleep(2000);
        }

    }
}
