using System;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    class ConcreteObserverB : IObserver
    {

        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            Console.WriteLine("State: " + subject.State);
        }
    }
}