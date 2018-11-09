using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{

    public class EarlySingleton
    {
        //Create instance eagerly
        private static EarlySingleton  earlySingleton = new EarlySingleton();

        private EarlySingleton()
        { Console.WriteLine("Early Instance Singleton Implementation..."); }

        public static EarlySingleton GetInstanceMethod()
        {
            Console.WriteLine("Early Instance Singleton Implementation by Method...");
            return earlySingleton;//just return the instance
        }

        public static EarlySingleton GetInstanceProperty
        {
            get
            {
                Console.WriteLine("Early Instance Singleton Implementation by Property...");
                return earlySingleton;
            }
        }
    }
}
