using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class ColoredCircle : BetterCircle
    { 
        // instead of copy+paste from my BetterCircle class,
        // i can inherit all of its behaviors/properties

        public string Color { get; set; }
        // add one property to the class in addition to everything it inherits from better circle
    }
}
