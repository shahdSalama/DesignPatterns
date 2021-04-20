using StrategyPatern.AbstractClasses;
using StrategyPatern.ConcreteClasses.Display;

using StrategyPatern.ConcreteClasses.Fly;
using StrategyPatern.ConcreteClasses.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> Ducks = new List<Duck>();
            DisplayAsGraphic dislayGraphically = new DisplayAsGraphic();
            QuackInSpeakers QuackSpeaker = new QuackInSpeakers();

            Duck rubberDuck = new Duck(QuackSpeaker, dislayGraphically, null);
            Ducks.Add(rubberDuck);

            QuackNaturally quackNaturally = new QuackNaturally();
            FlyWithWings flyWithWings = new FlyWithWings();
           
            Duck realDuck = new Duck(quackNaturally, dislayGraphically, flyWithWings);
            
            Ducks.Add(realDuck);

            foreach (Duck duck in Ducks)
            {
                duck.QuackBehaviour.Quack();
                duck.DisplayBehaviour.Display();
				duck.FlyBehaviour?.Fly();
                Console.WriteLine("*******************");
            }
            Console.Read();
        }
    }
}
