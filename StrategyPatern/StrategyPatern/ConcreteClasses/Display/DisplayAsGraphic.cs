using StrategyPatern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern.ConcreteClasses.Display
{
    public class DisplayAsGraphic : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("Display as Graphic");
        }

       
    }
}
