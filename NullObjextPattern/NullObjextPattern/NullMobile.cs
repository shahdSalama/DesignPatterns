using System;

namespace NullObjextPattern
{

    //our null object class implementing IMobile interface as a singleton  
    public class NullMobile : IMobile
    {
        //2. make a static private instance of the class
        private static NullMobile _instance;
        
        //1. make constructor private
        private NullMobile()
        { }

        //3. public static instance gets the private static instance.
        public static NullMobile GetInstance
        {
            //4.  if the private static instance is null create a new one
            // set _instance to the new instance and return it.

            get
            {
                if (_instance == null)
                    _instance =  new NullMobile();
                return _instance;
            }
        }

        //do nothing methods  
        public void TurnOff()
        {
            Console.WriteLine("\nNo mobile!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nNo mobile!");
        }
    }
}
    
