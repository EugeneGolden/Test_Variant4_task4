using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Variant4_Task4
{
    class Program
    {
        //Для масиву, відсортованого за зростанням, вивести номер елемента, після якого потрібно вставити деяке число y.
        static void Main(string[] args)
        {
            int n;
            int index = 0;
            string value;
            string anotherValue;
            double arrayElement;
            double analyzeElement;

            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());

            double[] newArray = new double[n];
            

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i+1) + "й элемент: (десятичные числа вводите, используя запятую) ");
                value = Console.ReadLine();
                if (Double.TryParse(value, out arrayElement))
                    Console.WriteLine("'{0}' --> {1}", value, arrayElement);
                else
                    Console.WriteLine("Unable to parse '{0}'.", value);
                newArray[i] = arrayElement;
            }

            Array.Sort(newArray);
            Console.WriteLine("Сортированый массив: ");

            foreach (var c in newArray)
            {
                Console.Write(" " + c);
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Введите число для анализа его места в массиве: (десятичные числа вводите, используя запятую) ");
            anotherValue = Console.ReadLine();
            if (Double.TryParse(anotherValue, out analyzeElement))
                Console.WriteLine("'{0}' --> {1}", anotherValue, analyzeElement);
            else
                Console.WriteLine("Unable to parse '{0}'.", anotherValue);
            

            for (int i = 0; i < n; i++)
            {
                if (analyzeElement < newArray[0])
                {
                    index = 0;
                }
                else if (analyzeElement >= newArray[n - 1])
                {
                    index = n;
                }
                else if ((analyzeElement >= newArray[i]) && (analyzeElement < newArray[i+1]))
                {
                    index = (i + 1);
                }
            }
            Console.WriteLine("Индекс в массиве " + index);
            Console.ReadKey();
        }
    }
}
