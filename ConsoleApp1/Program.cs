using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Age = 12;
            stu.Name = "K";
            int a;
            a = 100;
            int b;
            b = 200;
            int c;
            c = a + b;
            Console.WriteLine(c);
        }
        private int Add(int a, int b)
        {
            return a + b;
        }

        private double Add2(double a, double b)
        {
            return a + b;
        }
    }
    class Student
    {
        public static int Amount = 10;
        public int Age;
        public string Name;
    }

    class Calculater
    {
        public double GetCircleArea(double r)
        {
            return 3.14 * r * r;
        }
        public double GetCylinderVolumn(double r,double h)
        {
            return 3.14 * r * r * h;
        }
    }
}
