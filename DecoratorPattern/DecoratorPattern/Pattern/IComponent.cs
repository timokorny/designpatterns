using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern.Pattern
{
    public interface IComponent
    {
        string Operation(string data);
    }
}
