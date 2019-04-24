using System;
using System.Collections.Generic;
using System.Text;

// namespace matches the folder hierarchy
namespace Shapes.Library.Interfaces
{
    // in an interface, all members, must share the access of the whole interface
    // automatically must share the access of the whole interface
    public interface IShape
    {
        double GetPerimeter();
        double Area { get; }

        int Sides { get; }


    }
}
