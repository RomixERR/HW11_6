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
        const string pathFileName = "basa.json";
        static EmployerBankA employer;
        static ConsoleMenu firstMenu = new ConsoleMenu();
        static ConsoleMenu mainMenu = new ConsoleMenu();
        static FakeUser fakeUser = new FakeUser();
        static void Main(string[] args)
        {
            firstMenu.HeaderColor = ConsoleColor.Green;
            firstMenu.Header = "ВАС ПРИВЕТСТВУЕТ БАНК А";
            firstMenu.SubTitle = "Выберете пользователя";
            firstMenu.addMenuItem(0, "Консультант", MItemKonsult);
            firstMenu.addMenuItem(1, "Менеджер", MItemManager);
            firstMenu.addMenuItem(2, "Выход",MItemExit);
            firstMenu.showMenu();
        }
        public static void MainMenu()
        {
            Console.Clear();
            mainMenu.HeaderColor = ConsoleColor.Green;
            mainMenu.Header = "ВАС ПРИВЕТСТВУЕТ БАНК А";
            while (true)
            {
                mainMenu.clear();
                mainMenu.SubTitle = $"=========М=Е=Н=Ю===========\n" +
                                    $"Вы зашли под [{employer}]\n" +
                                    $"===========================";
                if (employer is Manager)
                {
                    mainMenu.addMenuItem(0, "Вывести данные на экран", MItemPrint);
                    mainMenu.addMenuItem(1, "Добавить новую запись", MItemAddNewRecord);
                    mainMenu.addMenuItem(2, "Изменить телефон", MItemChangePhoneNumber);
                    mainMenu.addMenuItem(3, "Изменить номер паспорта", MItemChangePasportNumber);
                    mainMenu.addMenuItem(4, "Изменить фамилию", MItemChangeLastName);
                    mainMenu.addMenuItem(5, "Изменить имя", MItemChangeFirstName);
                    mainMenu.addMenuItem(6, "Изменить отчество", MItemChangeMiddleName);
                    mainMenu.addMenuItem(7, "Изменить жене", MItemChangeWife);
                }
                else
                {
                    mainMenu.addMenuItem(0, "вывести данные на экран", MItemPrint);
                    mainMenu.addMenuItem(1, "изменить Телефон", MItemChangePhoneNumber);
                    mainMenu.addMenuItem(2, "Изменить номер паспорта", MItemChangePasportNumber);//
                }
                mainMenu.addMenuItem(8, "Выход", MItemExit);
                mainMenu.showMenu();
            }
        }
    }
}
