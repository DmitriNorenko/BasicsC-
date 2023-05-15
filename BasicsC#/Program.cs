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
            const string MyName = "Dmitry";
            Console.WriteLine(MyName);
            Console.WriteLine("Привет,Мир!\n");
            Console.WriteLine("\tМне 21 год.");
            Console.WriteLine($"Меня зовут {MyName}.");
            Console.WriteLine("\u0023");
            Console.WriteLine("Анкета.");
            Console.WriteLine($"Меня зовут {MyName}.");
            Console.WriteLine("Мне 21 год.");
            Console.WriteLine("Есть ли у меня питомец? True");
            Console.WriteLine("Мой размер ноги 43");
            Console.ReadKey();
        }
    }
}
