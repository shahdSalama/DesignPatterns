using System;

namespace NullObjextPattern
{
    internal class AppleIPhone : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\nAppleIPhone Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nAppleIPhone Turned ON!");
        }
    }
}