using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._2_Высокий_уровень_Вар_2
{
    internal class Program
    {
      
    const int n = 6;
        static string[] a = new string[n] { "Иванов", "Петров", "Сидоров", "Лаптев", "Жылин", "Носов" };
        static double[] b = new double[n] { 15, 13.9, 16.1, 14.2, 14.5, 15.3 };

        static void Main()
        {
            string[] sa = new string[n];
            double[] sb = new double[n];
            for (int i = 0; i < n; i++)
            {
                sa[i] = a[i];
                sb[i] = b[i];
            }

            // сортировка по возрастанию времени
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (sb[j] > sb[j + 1])
                    {
                        string s = sa[j];
                        sa[j] = sa[j + 1];
                        sa[j + 1] = s;

                        double t = sb[j];
                        sb[j] = sb[j + 1];
                        sb[j + 1] = t;
                    }
                }
            }

            // Вывод
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{sa[i]} - {sb[i]}");
            }
        }
    }
}

