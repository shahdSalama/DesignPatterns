using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjextPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var mobileRepository = new MobileRepository();
            IMobile mobile = mobileRepository.GetMobileByName("sonym");
            mobile.TurnOn();
            mobile.TurnOff();
            Console.Read();
        }
    }
}