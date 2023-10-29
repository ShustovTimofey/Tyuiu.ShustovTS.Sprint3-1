using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint3.Task4.V11.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.Title = "Спринт #3 | Выполнил: Шустов Т.С. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = x / (sin(x) - x) + 2 При х = 0 прервать цикл.               *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало интервала: {startValue}");
            Console.WriteLine($"Конец интервала: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
