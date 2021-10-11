/*
ver: 0.01a date: 2021.10.09
autor: Mikhail625@protonmail.com
                Tip: for formatting Ctrl + K, а затем Ctrl + D.
*/

/* Задания. Условия.
Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet *). 
Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями, 
но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.

Для каких методов потребуется написать тест
... обычный метод расчёта дистанции :
1. ... со ссылочным типом (PointClass — координаты типа float).
2. ... со значимым типом (PointStruct — координаты типа float).
3. ... со значимым типом (PointStruct — координаты типа double).
4. ... без квадратного корня со значимым типом (PointStruct — координаты типа float).

    Результаты можно оформить в виде списка или таблицы, в которой наглядно можно будет увидеть 
    время выполнения того или иного метода.

 
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
        { // для минимизации кода в Main () стартуем запускалку () задач ..
            TaskStart ts = new TaskStart(); ts.Run ("Task001");
        } // end of Main()

    } // end of class Programm

   class TaskStart// class TaskStart - это диспечер\запускалка всех задач (ДЗ). 
                  // Старт задач - последовательно. Либо (более продвинутый вариант) на выбор, через меню

    {
        public void Run (string TaskName)
        { 
            Tasks t1 = new Tasks();
            t1.Task001();

        }
     
    }// end of class TaskStart


    class Tasks  // class Tasks - непосредственно код решения задач 
    { 
        public void Task001 ()
        {   Console.WriteLine("OK/ Now trying run the .. {TaskStart}");  //  Run (string TaskName)
            Console.ReadKey();
            int sizeArr1 = 22; // размер тестового массива
            Point[] pa1 = new Point[sizeArr1];

           Ptest pt1 =new Ptest();
            pa1 = pt1.CreateArrPoint(sizeArr1);


            Console.ReadKey();


        }
    
    } // end class Tasks 



    struct PointStruct
    {
        public string namePoint;
        public int x;
        public int y;

        // конструктор 1 : 
        public PointStruct(string name, int x , int y)
        {
            this.namePoint = name;
            this.x = x;
            this.y = y;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {namePoint}  X: {x}    Y: {y}");
        }

    } // end 0f truct Point

    class PointClass
    {
        public string namePoint;
        public int x;
        public int y;

        // конструктор 1 : 
        public PointClass(string name, int x , int y)
        {
            this.namePoint = name;
            this.x = x;
            this.y = y;
        }

        // конструктор 2  : 
        //Структуры не могут содержать явных конструкторов без параметров.
        public PointClass()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            this.x = rnd1.Next(0,150);
            this.y = rnd2.Next(0,150);
            namePoint = "X"+ this.x+"_Y"+ this.y;
        }
    }


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

   class Ptest // prepare for test
    { 
        public Point[] CreateArrPoint (int sizeArr) //  переделать в структуру кортеж
        {   int i =0;

            Random rnd1 = new Random();//System.Threading.Thread.Sleep(1000);
            Random rnd2 = new Random();
            Random rnd3 = new Random();

            int xR = rnd1.Next(0, 150);Thread.Sleep(1001);
            int yR = rnd2.Next(0, 150);
            int rp1 = rnd3.Next(10,500);

            Point[] pa1 = new Point[sizeArr];

            do
            {
                pa1[i].namePoint = i+ "._" + "X:"+xR + "_Y:"+yR;
                pa1[i].x = xR; 
                pa1[i].y = yR;
                i++;
                Thread.Sleep(rp1); xR = rnd1.Next(0, 150);rp1 = rnd3.Next(10,500);
                Thread.Sleep(rp1); yR = rnd2.Next(0, 150);
            }
            while (i <sizeArr);

            i--;
            do
            {
                Console.WriteLine("name:[{0}]\tX:[{1}]\tY:[{2}]"  , pa1[i].namePoint, pa1[i].x , pa1[i].y);
                i--;
            }
            while (i>= 0);

     return pa1;
        }
    } //   class Ptest // prepare for test


}  // end of namespace gbQ2lesson_003
