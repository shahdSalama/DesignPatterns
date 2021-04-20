using StrategyPatern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern.AbstractClasses
{
    public class Duck
    {
        public Duck(IQuackBehaviour quackBehaviour, IDisplayBehaviour displayBehaviour, IFlyBehaviour flyBehaviour)
        {
            QuackBehaviour = quackBehaviour;
            DisplayBehaviour = displayBehaviour;
            FlyBehaviour = flyBehaviour;
        }

        public IQuackBehaviour QuackBehaviour { get; set; }
        public IDisplayBehaviour DisplayBehaviour { get; set; }
        public IFlyBehaviour FlyBehaviour { get; set; }
    }
}
