﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText(@"C:\Users\77777\Desktop\Checking\drdr\input.txt");
            //Указываем путь к файлу и присваем его значение в path
            string newpath = new string(path.ToCharArray().Reverse().ToArray());
            //стринг path делаем реверс и его присваеваем в newpath
            string text = "Yes";
            string text2 = "No";
            if (path == newpath)  //сравниваем оба массива
            {
                File.WriteAllText(@"C:\Users\77777\Desktop\Checking\Output.txt", text);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Yes");
                
            }
            else
            {
                File.WriteAllText(@"C:\Users\77777\Desktop\Checking\Output.txt", text2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No");
               
            }
        }
    }
}