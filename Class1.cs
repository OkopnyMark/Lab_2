using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Classes
{
    abstract class Figure
    {
        public string Type;
        public abstract double Area();
        public override string ToString()
        {
            return this.Type + " с площадью  " + this.Area().ToString();
        }

    }
    interface IPrint
    {
        void Print();
    }
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;
        public Rectangle(double wid, double hei)
        {
            this.width = wid;
            this.height = hei;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    class Square : Rectangle, IPrint
    {
        public Square(double len)
            : base(len, len)
        {
            this.Type = "Квадрат";
        }
    }
    class Circle : Figure, IPrint
    {
        double radius;
        public Circle(double rad)
        {
            this.radius = rad;
            this.Type = "Круг";
        }
        public override double Area()
        {
            const double pi = 3.14;
            double Result = pi * this.radius * this.radius;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}