using System;
using System.Collections.Generic;
using System.Text; 

namespace kt11
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Тип фигуры: {shape.GetType().Name}");
                Console.WriteLine($"Площадь: {shape.Area():F2}");
                Console.WriteLine($"Периметр: {shape.Perimeter():F2}");

                if (shape is IDrawable drawableShape)
                {
                    Console.WriteLine("Текстовое представление:");
                    Console.WriteLine(drawableShape.Draw());
                }

                Console.WriteLine(new string('-', 25));
            }
        }
    }
}