using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HW11_6.InputClass;

namespace HW11_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string pathFileName = "basa.json";
            bool extFlag = false;
            EmployerBankA employer;

            int P = Input<int>("Выберете пользователя: Консультант = 1, Менеджер = 2, Выход = 0 (или пустой ввод)", 0 );
            if (P == 1)
            {
                employer = new Consultant(pathFileName);
            }
            else if (P == 2)
            {
                employer = new Manager(pathFileName);
            }
            else return;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====Меню====");
                Console.WriteLine($"Вы зашли под [{employer}]");
                Console.WriteLine("============");
                Console.WriteLine("0 - выход");
                Console.WriteLine("1 - вывести данные на экран");
                Console.WriteLine("2 - добавить новую запись");
                Console.WriteLine("3 - изменить Фамилию");
                Console.WriteLine("4 - изменить Имя");
                Console.WriteLine("5 - изменить Отчество");
                Console.WriteLine("6 - изменить Телефон");
                Console.WriteLine("7 - изменить жене");
                Console.WriteLine("8 - изменить Номер паспорта");

                P = Input<int>();
                if (P == 0) break;
            }

            Console.WriteLine("Спасибо за использование программы нашего банка!");
            Thread.Sleep(2000);
        }

        
    }
}
