using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());  //Размер массива

            int[] a = new int[n];           //Новый массив
            for (int i = 0; i < n; i++)    //Пробегаемся по массиву
            {
                a[i] = Convert.ToInt32(Console.ReadLine());           //Ввод элементов массива через консоль
            }
            Console.WriteLine("Array: ");
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");  // Элементы массива
            }
            Console.WriteLine();
            Console.WriteLine("Duplicates:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");         //Дублируем элементы массива
            }

        }
    }
}