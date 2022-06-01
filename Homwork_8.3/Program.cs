using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> sets = new HashSet<int>();

            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите любое целое число: ");
                string UserNumberString = Console.ReadLine();

                if (UserNumberString == "")
                {
                    Console.WriteLine("\nДобавленные числа:");
                    foreach (var set in sets)
                    {
                        Console.Write($"{set}\0");
                    }

                    Console.ReadKey();
                    break;
                }

                if (UserNumberString != "")
                {
                    int UserNumberInt = int.Parse(UserNumberString);

                    if (sets.Contains(UserNumberInt))
                    {
                        Console.WriteLine("\n Данное число уже добавлено.\n");
                    }
                    else
                        sets.Add(UserNumberInt);
                }
            }

        }
    }
}
