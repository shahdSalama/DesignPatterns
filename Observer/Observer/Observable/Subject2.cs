using RefactoringGuru.DesignPatterns.Observer.Conceptual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Observable
{
    class Subject2 : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();

        public int State { get; set; } = 0;

        public void Attach(IObserver observer)
        {

            Console.WriteLine("Subject 2: Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {

            Console.WriteLine("Subject 2: Detached an observer.");
            _observers.Remove(observer);
        }

        public void Notify()
        {

            Console.WriteLine("Subject 2: Notifying.");
            foreach (var observer in _observers)
            {

                observer.Update(this);
            }
            
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject 2: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject 2: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
