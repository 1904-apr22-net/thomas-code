﻿using Shapes.Library;
using Shapes.Library.Interfaces;
using System;

namespace Shapes.UI
{
    public class Program
    {
        // "private" means, only the current class can see the item.
        static void Main(string[] args)
        {
            Circle cir = new Circle();

            // not allowed, because, "radius" is "private".

            // double r = cir.radius;

            // using the getter method instead

            double r = cir.GetRadius();

            cir.SetRadius(-4);

            BetterCircle better = new BetterCircle();

            // the #1 benefit of properties is we can access them
            // using better syntax like this:

            better.Radius = 5;
            Console.WriteLine(better.Radius);

            // the code in the "get" and "set" of the property
            // is being run. the field is still hidden from me.
                      
            Console.WriteLine("Hello World!");

            ShapeWork();

        }

        static void ShapeWork()
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("Please enter the length.");
            r.Length = int.Parse(Console.ReadLine());
            r.Width = 3;
            
            Console.WriteLine(r.GetPerimeter());
            Console.WriteLine(r.Area);

            //BetterCircle Circle = new BetterCircle();
            //BetterCircle Circle = new NoisyCircle();
            NoisyCircle noisyCircle = new NoisyCircle();
            BetterCircle Circle = noisyCircle; //upcasting
            Circle.Radius = 8;

            noisyCircle.GetPerimeter();
            Circle.GetPerimeter();

            Console.WriteLine();

            PrintShapeDetails(r, "rectangle");
            PrintShapeDetails(Circle, "circle");

            ColoredCircle blueCircle = new ColoredCircle();                     
        }
        static void PrintShapeDetails(IShape shape, string name)
        {
            Console.WriteLine("Shape " + name);
            Console.WriteLine("Area is " + shape.Area);
            Console.WriteLine("Perimeter is " + shape.GetPerimeter());
            Console.WriteLine("Sides is " + shape.Sides);
            Console.WriteLine();
        }
    }

}
