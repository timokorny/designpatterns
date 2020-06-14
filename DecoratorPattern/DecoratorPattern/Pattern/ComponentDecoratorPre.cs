using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern.Pattern
{
    public class ComponentDecoratorPre : IComponent
    {
        private IComponent component;

        public ComponentDecoratorPre(IComponent compo)
        {
            component = compo;
        }

        public string Operation(string data)
        {
            return "Pre decoration " + component.Operation(data);
        }
    }
}
