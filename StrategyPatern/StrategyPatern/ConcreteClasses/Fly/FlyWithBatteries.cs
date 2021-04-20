using StrategyPatern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern.ConcreteClasses.Fly
{
    public class FlyWithBatteries : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Batteries");
        }
    }
}
