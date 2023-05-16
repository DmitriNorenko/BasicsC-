using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 21;
            bool HaveIApet = true;
            double MyShoeSize = 43.0;
            const string MyName = "Dmitry";
            Console.WriteLine(MyName);
            Console.WriteLine("Привет,Мир!\n");
            Console.WriteLine("\tМне 21 год.");
            Console.WriteLine($"Меня зовут {MyName}.");
            Console.WriteLine("\u0023");
            Console.WriteLine("Анкета.");
            Console.WriteLine($"Меня зовут {MyName}.");
            Console.WriteLine($"Мне {age} год.");
            Console.WriteLine($"Есть ли у меня питомец? {HaveIApet}");
            Console.WriteLine($"Мой размер ноги " + MyShoeSize);
            Console.WriteLine("ByteMin {0}", byte.MinValue);
            Console.WriteLine("ByteMax {0}", byte.MaxValue);
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
