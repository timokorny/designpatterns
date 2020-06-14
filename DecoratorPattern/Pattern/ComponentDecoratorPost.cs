using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern.Pattern
{
    public class ComponentDecoratorPost : IComponent
    {
        private IComponent component;

        public ComponentDecoratorPost(IComponent compo)
        {
            component = compo;
        }

        public string Operation(string data)
        {
            return component.Operation(data) + " post decoration";
        }
    }
}
