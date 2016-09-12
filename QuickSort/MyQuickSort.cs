using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class MyQuickSort
    {
        static int Partition<T>(T[] m, int a, int b)
            where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    T t = m[i];                  // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    m[i] = m[j];                 // то есть переносим элементы меньшие m[b] в начало,
                    m[j] = t;                    // а затем и сам m[b] «сверху»
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }

        public static void QuickSort<T>(T[] m, int a, int b) where T : IComparable<T>// a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            /*if (a >= b) return;
            int c = Partition(m, a, b);
            QuickSort(m, a, c - 1);
            QuickSort(m, c + 1, b);*/
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count;
            int.TryParse(input, out count);
            int[] arr = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rand.Next(100);
                Console.Write(arr[i].ToString()+' ');
            }
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i].ToString() + ' ');
            }
            Console.ReadLine();
        }

                
    }
}
