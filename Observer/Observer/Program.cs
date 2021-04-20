using Observer.Observable;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{

	class Program
	{
		static void Main(string[] args)
		{
			// The client code.
			var subject = new Subject();
			//  var subject2 = new Subject2();

			var observerA = new ConcreteObserverA();

			subject.Attach(observerA);
			subject.SomeBusinessLogic();
			subject.Detach(observerA);
			subject.SomeBusinessLogic();

			//  var observerB = new ConcreteObserverB();

			//   subject.Attach(observerB);

			// subject2.Attach(observerB);
			//  subject2.SomeBusinessLogic();


			// subject.SomeBusinessLogic();

			//  subject.Detach(observerB);

			//  subject.SomeBusinessLogic();

			//  subject2.Detach(observerB);

			// subject2.SomeBusinessLogic();
		}
	}
}