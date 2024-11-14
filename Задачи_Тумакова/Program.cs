using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_Тумакова
{
    enum ВУЗ
    {
        КГУ,
        КАИ,
        КХТИ
    }
    enum Bank
    {
        Текущий,
        Сберегательный
    }
    struct BankAccountt
    {
        public long num;
        public string name;
        public float balans;
        public void Print()
        {
            Console.WriteLine("Номер счёта - {0} \nВид счёта - {1} \nБаланс - {2}$ \n",num,name,balans);
        }
    }
    struct Employee
    {
        public string name;
        public ВУЗ university;

        public void Print()
        {
            Console.WriteLine("{0} - {1}",name,university);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать */
            Console.WriteLine("Упражнение 3.1");
            Bank account = Bank.Текущий;
            Console.WriteLine($"Вид банковского счёта: {account}\n");

            /* Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат. */
            Console.WriteLine("Упражнение 3.2");
            BankAccountt inf;
            inf.num = 2200220000220022;
            inf.name = "Текущий";
            inf.balans = 25005.67f;
            inf.Print();

            /* Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать */
            Console.WriteLine("Домашнее задание 3.1");
            ВУЗ Place = ВУЗ.КАИ;
            Employee dataBase;
            dataBase.name = "Романов Иван Олегович";
            dataBase.university = Place; 
            dataBase.Print();
            Console.ReadKey();
            
            
            


        }
    }
}
