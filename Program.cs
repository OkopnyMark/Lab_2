using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;


namespace Lab2_Vasilyev
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(14, 4);
            rect.Print();
            Square sq = new Square(6);
            sq.Print();
            Circle sc = new Circle(7);
            sc.Print();
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}