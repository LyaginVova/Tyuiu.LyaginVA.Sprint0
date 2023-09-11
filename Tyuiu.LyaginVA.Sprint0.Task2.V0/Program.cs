using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.LyaginVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.LyaginVA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метод GetMessage
            //из библиотеки Tyuiu.LyaginVA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Вова"));
            Console.ReadKey();
        }
    }
}
