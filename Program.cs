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
        }
        public static void MainMenu()
        {
            Console.Clear();
            while (true)
            {
                mainMenu.clear();
                mainMenu.SubTitle = $"==== Меню =================\n" +
                                    $"Вы зашли под [{employer}]\n" +
                                    $"===========================";
                if (employer is Manager)
                {
                    mainMenu.addMenuItem(0, "вывести данные на экран", MItemPrint);
                    mainMenu.addMenuItem(1, "добавить новую запись", MItemAddNewRecord);
                    mainMenu.addMenuItem(2, "изменить Телефон", MItemChangePhoneNumber);
                    mainMenu.addMenuItem(3, "изменить Номер паспорта", MItemChangePasportNumber);
                    mainMenu.addMenuItem(4, "изменить Фамилию", MItemChangeLastName);
                    mainMenu.addMenuItem(5, "изменить Имя", MItemChangeFirstName);
                    mainMenu.addMenuItem(6, "изменить Отчество", MItemChangeMiddleName);
                    mainMenu.addMenuItem(7, "изменить жене", MItemChangeWife);
                }
                else
                {
                    mainMenu.addMenuItem(0, "вывести данные на экран", MItemPrint);
                    mainMenu.addMenuItem(1, "изменить Телефон", MItemChangePhoneNumber);
                }
                firstMenu.addMenuItem(8, "Выход", MItemExit);
                mainMenu.showMenu();
            }
        }
    }
}
