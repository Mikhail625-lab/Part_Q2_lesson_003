/*
ver: 0.01a date: 2021.10.09
autor: Mikhail625@protonmail.com
                Tip: for formatting Ctrl + K, а затем Ctrl + D.
*/

/* Задания. Условия.
Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet. 
Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями, 
но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.

Для каких методов потребуется написать тест:
Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
Результаты можно оформить в виде списка или таблицы, в которой наглядно можно будет увидеть время выполнения того или иного метода.

 *
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;


namespace gbQ2lesson_003
{
    class Program
    {
        static void Main(string[] args)
        {
        } // end of Main()



        class UTest
        {
            public bool IsPrime(int digit)
            { }


            } // end of class Programm
}  // end of namespace gbQ2lesson_003
