using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class NoisyCircle : BetterCircle
    {
        // goal is to override parent class. add alot of writeline to print out what is happening to this object

        // in C#, by default you cant override, only add new properties/methods
        // instead we opt-in to the possibility of override in parent class by usiing "virtual" modifier.

        // we opt-in to the possibility of override in the parent class
        // using "virtual" modifier.
        public override double Radius
        {
            // with private access, even a subclass cannot see that thing
            get
            {
                Console.WriteLine("Getting radius");
                return _radius * 1.01;
            }

            set
            {
                Console.WriteLine("Setting radius");
                _radius = value;
            }

         }

        public override double GetPerimeter()
        {
            Console.WriteLine("getting perimeter.");
            // we can always access the parent class's implementation with
            // "base"
            return base.GetPerimeter();
        }


        public override double Area
        {
            get
            {
                Console.WriteLine("Getting area.");
                return base.Area;
            }
        }

    }
}

        

    

