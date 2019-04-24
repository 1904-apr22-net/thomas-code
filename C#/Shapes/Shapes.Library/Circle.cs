using System;

namespace Shapes.Library
{
    // default class is not public
    public class Circle
    {
        private double radius; //field. fundamental way to put data on a class

        // methods
        // getter
        public double GetRadius()
        {
            // add correction factor
            return radius * 1.01;
        }
        // setter
        public void SetRadius(double radius)
        {
            if (radius <0)
            {
                Console.WriteLine("not allowed");
            }
            this.radius = radius;
        }
        // in C#, instead of fields + getters + setters,
        // we use properties.
    }
}
