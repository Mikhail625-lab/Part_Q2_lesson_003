/*
ver: 0.01a date: 2021.10.09
autor: Mikhail625@protonmail.com
                Tip: for formatting Ctrl + K, а затем Ctrl + D.
*/

/* Задания. Условия.
Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet *). 
Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями, 
но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.

Для каких методов потребуется написать тест:
Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
Результаты можно оформить в виде списка или таблицы, в которой наглядно можно будет увидеть время выполнения того или иного метода.

 
 *)  Next you need to run the following from your Package Manager console to install the BenchmarkDotNet nuget package :

Install-Package BenchmarkDotNet
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;
using System.Threading;


namespace gbQ2lesson_003
{
    class Program
    {
        static void Main(string[] args)
        {
          
        } // end of Main()



    } // end of class Programm


    struct Point
    {
        public string namePoint;
        public int x;
        public int y;

        // конструктор 1 : 
        public Point(string name, int x , int y)
        {
            this.namePoint = name;
            this.x = x;
            this.y = y;
        }

        // конструктор 2  : 
        /*Структуры не могут содержать явных конструкторов без параметров.
        public Point()
        {
            Random rnd1 = new Random();
            System.Threading.Thread.Sleep(1000); 
            Random rnd2 = new Random();

            this.x = rnd1.Next(0,150);
            this.y = rnd2.Next(0,150);
            namePoint = "X"+ this.x+"_Y"+ this.y;
        }

        */

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {namePoint}  X: {x}    Y: {y}");
        }

    } // end 0f truct Point

    class UTest
    {

            public Stopwatch sw = new Stopwatch();
            public string resultB = "";
            public TimeSpan ts ;

        public void Start()
        {
            resultB = "";
            sw.Start();
        }

        public void Stop()
        {
            sw.Stop();
            ts = sw.Elapsed;
            
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            resultB = elapsedTime;
        }

        public string DisplayResult() { return resultB; }

} // enf of   class UTest

   
}  // end of namespace gbQ2lesson_003
