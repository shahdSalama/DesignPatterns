using System;

namespace NullObjextPattern
{
    internal class SonyXperia :IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\nSonyXperia Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nSonyXperia Turned ON!");
        }
    }
}