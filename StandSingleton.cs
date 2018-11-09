using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class StandSingleton
    {
        private static StandSingleton standSingleton = null;

        private StandSingleton()
        { Console.WriteLine("Standarded Implementation First Time Calling....."); }

        // GetInstance method to return the instance of this class...
        public static StandSingleton GetInstanceMethod()
        {
            if (standSingleton == null)
            {
                Console.WriteLine("Standarded Implementation Create Instance by Method.....");
                standSingleton = new StandSingleton();
            }
            return standSingleton;
        }

        // GetInstance Property to return the instance of this class...
        public static StandSingleton GetInstancePropperty
        {
            get
            {
                if (standSingleton == null)
                {
                    Console.WriteLine("Standarded Implementation Create Instance by Property.....");
                    standSingleton = new StandSingleton();
                }
                return standSingleton;
            }
        }

    }
}
