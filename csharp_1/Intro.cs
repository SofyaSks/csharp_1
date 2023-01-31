using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp_1
{
    //PE .exe or .dll - PE: время сборки, тип файла и время выполняемого код,
    //CRL (заголовок): информация для среды исполнения модуля(характеристики метаданных), метаданные - при компиляции не нужны заголовочные/библиотечные файлы, 
    //CIL: промежуточный код
    //сборка - базовый строительный блок приложения net.framework, могут быть несколько файлов, которые мы позволяем собрать в единое целое
    //манифест - хэш, типы/ресурсы извне, прописана зависимость от других сборок, набор прав необходимых для сборки
    // у каждого объекта  свой хэш

    class Intro
    {

        static void Main(string[] args)
        {
            /*double num1 = 1;
            double num2 = 3;
            double res = num1/num2;
            WriteLine(res);
            WriteLine(res * num2);*/

            /* decimal num1 = 1;
             decimal num2 = 3;
             decimal res = num1 / num2;
             WriteLine(res);
             WriteLine(res * num2);*/

            //BackgroundColor = ConsoleColor.Yellow;
            //ForegroundColor = ConsoleColor.Blue;
            //SetWindowSize(20, 10);
            //SetBufferSize(20, 10);

            //WriteLine("enter name: ");
            //string name;
            //name = ReadLine();
            //if (name == "") WriteLine("Hello world");
            //else WriteLine("hello " + name + "!");

            /*int x = 10;
            double y = 10;
            float n = 12.0f;
            float res = x + n;
            int res1 = (int)(x + n);
            WriteLine(res1);*/

            /*WriteLine("enter number: ");
            string str;
            str = ReadLine();
            int int_num = Convert.ToInt32(str);
            WriteLine(int_num + 10);*/

            /*WriteLine(10 + 10);
            WriteLine("10" + "10");
            WriteLine(10 + "10");*/

            /*bool n = true;
            if (n)
                WriteLine("true");
            else
                WriteLine("false");*/

            /* int size = 10;
             int[] arr = new int[10];
             Random rand = new Random();
             for (int i = 0; i < size; i++)
             {
                 arr[i] = rand.Next(-20, 20);
                 Write(arr[i] + " ");
             }
             WriteLine();

             foreach (var item in arr)
             {
                 Write(item + " ");
             }
             WriteLine();*/

            int[,] ar_2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // or int[,] ar_2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; 

            int[,,] ar_3 = new int[2, 3, 3] { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };

            int n;

            /*switch (n)
            {
                case 1: WriteLine("1");
                    break;
                case 1:
                    WriteLine("1");
                    break;
                case 1:
                    WriteLine("1");
                    break;

                default: WriteLine("Error");
                    break;
            }*/
        }
    }
}
