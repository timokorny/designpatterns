using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern.Pattern
{
    public class Component : IComponent
    {
        public string Operation(string data)
        {
            return "Information: " + data;
        }
    }
}
