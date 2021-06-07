using System;

namespace NullObjextPattern
{
    public abstract class Employee
    {
        public abstract bool IsTimeToPay(DateTime time);
        public abstract void Pay();

        public static readonly Employee NULL = new NullEmployee();
        private class NullEmployee : Employee
        {
            public override bool IsTimeToPay(DateTime time)
            {
                return false;
            }
            public override void Pay()
            {
            }
        }
    }
    public class ConcreteEmployee : Employee
    {
        public override bool IsTimeToPay(DateTime time)
        {
            return true;
        }

        public override void Pay()
        {
            Console.WriteLine("Pay");
        }
    }
}
