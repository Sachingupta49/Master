using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class MultiThreadSingleton
    {
        private static MultiThreadSingleton multiThreadSingleton = null;
        private static readonly object instanceLook = new object();

        private MultiThreadSingleton()
        {
            Console.WriteLine("Multithreading Environment Singleton Implementation...");
        }

        public static MultiThreadSingleton GetInstanceMethod()
        {
            lock (instanceLook)
            {
                if (multiThreadSingleton == null)
                {
                    Console.WriteLine("Multithreading Environment Singleton Implementation Create Instance by Method.....");
                    multiThreadSingleton = new MultiThreadSingleton();
                }
            }
            return multiThreadSingleton;
        }

        public static MultiThreadSingleton GetInstancePropery
        {
            get
            {
                lock (instanceLook)
                {
                    if (multiThreadSingleton == null)
                    {
                        Console.WriteLine("Multithreading Environment Singleton  Implementation Create Instance by Property.....");
                        multiThreadSingleton = new MultiThreadSingleton();
                    }
                }
                return multiThreadSingleton;
            }
        }
    }
}
