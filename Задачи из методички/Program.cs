using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задачи_из_методички
{
    struct DataBase
    {
        public string name;
        public string city;
        public string age;
        public string pin;
        public void Print()
        {
            Console.WriteLine($"Имя: {name} \nГород: {city} \nВозраст: {age} \nПин-код: {pin} \n");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение */
            Console.WriteLine("Номер 1 \nТип данных - максимальное значение - минимальное значение");
            Console.WriteLine("byte - {0} - {1}",byte.MaxValue,byte.MinValue);
            Console.WriteLine("sbyte - {0} - {1}", sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("short - {0} - {1}",short.MaxValue,short.MinValue);
            Console.WriteLine("ushort - {0} - {1}", ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int - {0} - {1}",int.MaxValue,int.MinValue);
            Console.WriteLine("uint - {0} - {1}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("long - {0} - {1}",long.MaxValue,long.MinValue);
            Console.WriteLine("long - {0} - {1}", ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("float - {0} - {1}",float.MaxValue,float.MinValue);
            Console.WriteLine("double - {0} - {1}",double.MaxValue,double.MinValue);
            Console.WriteLine("decimal - {0} - {1}\n",decimal.MaxValue,decimal.MinValue);

            /* 2) Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода.Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате */
            Console.WriteLine("Номер 2");
            DataBase data;
            Console.Write("Введите вааше имя: ");
            data.name = Console.ReadLine();
            Console.Write("Укажите ваш город: ");
            data.city = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            data.age = Console.ReadLine();
            Console.Write("Введите пин-код: ");
            data.pin = Console.ReadLine();
            data.Print();

            // 3) Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные //
            Console.WriteLine("Номер 3 \nВведите нексолько букв без пробелов");
            string text = Console.ReadLine();
            string word = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text.ToUpper()[i])
                {
                    word += text.ToLower()[i];
                }
                else
                {
                    word += text.ToUpper()[i];
                }
            }
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
