using System;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            Console.WriteLine("State: " + subject.State);
        }
    }
}