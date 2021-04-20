using StrategyPatern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern.ConcreteClasses.Quack
{
    public class QuackInSpeakers : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack in Speakers");
        }
    }
}
