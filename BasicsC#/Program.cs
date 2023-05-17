using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte age = 21;
            //bool HaveIApet = true;
            //double MyShoeSize = 43.0;
            //const string MyName = "Dmitry";
            //Console.WriteLine(MyName);
            //Console.WriteLine("Привет,Мир!\n");
            //Console.WriteLine("\tМне 21 год.");
            //Console.WriteLine($"Меня зовут {MyName}.");
            //Console.WriteLine("\u0023");
            //Console.WriteLine("Анкета.");
            //Console.WriteLine($"Меня зовут {MyName}.");
            //Console.WriteLine($"Мне {age} год.");
            //Console.WriteLine($"Есть ли у меня питомец? {HaveIApet}");
            //Console.WriteLine($"Мой размер ноги " + MyShoeSize);
            //Console.WriteLine("ByteMin {0}", byte.MinValue);
            //Console.WriteLine("ByteMax {0}", byte.MaxValue);
            //Console.WriteLine("\tПривет,\n мир!");
            //Console.WriteLine($"Мой возраст {age}");
            //Console.WriteLine("{0}\n{1}\n{2}", HaveIApet, age, MyShoeSize);
            //double result = 5.0 / 2.0;
            //Console.WriteLine("5 / 2 = {0}", result);
            //DaysOfWeek day = (DaysOfWeek) int.Parse(Console.ReadLine());
            //Console.WriteLine(day);
            //string str = Console.ReadLine();
            //Console.WriteLine(str);
            string NamePC = "Computer";
            Console.WriteLine("Привет, меня зовут {0}, а тебя?", NamePC);
            string MyName = Console.ReadLine();
            Console.WriteLine("Меня зовут " + MyName + ".");
            Console.WriteLine($"Приятно познакомиться {MyName}!");
            Console.WriteLine("{0}, сколько тебе лет?", MyName);
            bool CheckAge = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Мне " + age + ".");
            Console.WriteLine("Круто, а мне всего 1 год.)");
            Console.WriteLine("А когда ты родился?");
            string Data = Console.ReadLine();
            Console.WriteLine(" Ты родился : {0}. Это просто невероятно!\n Спасибо, что поговорил со мной,{1}.", Data, MyName);
            Console.WriteLine("Пока, " + NamePC + ".");
            Console.ReadKey();
        }
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
