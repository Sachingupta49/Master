using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class DblChkMultiThreadSingleton
    {
        private static DblChkMultiThreadSingleton dblChkMultiThreadSingleton = null;
        private static readonly object InstanceLook = new object();
        private DblChkMultiThreadSingleton()
        {
            Console.WriteLine("Double Check Multithreading Environment Singleton Implementation...");
        }

        public static DblChkMultiThreadSingleton GetInstanceMethod()
        {
            if (dblChkMultiThreadSingleton == null)
            {
                lock(InstanceLook)
                {
                    if(dblChkMultiThreadSingleton == null)
                    {
                        dblChkMultiThreadSingleton = new DblChkMultiThreadSingleton();
                        Console.WriteLine("Double Check Multithreading Environment Singleton Implementation Create Instance by Method.....");
                    }
                }
            }
            return dblChkMultiThreadSingleton;
        }

        public static DblChkMultiThreadSingleton GetInstanceProperty
        {
            get
            {
                if (dblChkMultiThreadSingleton == null)
                {
                    lock(InstanceLook)
                    {
                        if(dblChkMultiThreadSingleton == null)
                        {
                            dblChkMultiThreadSingleton = new DblChkMultiThreadSingleton();
                            Console.WriteLine("Double Check Multithreading Environment Singleton Implementation Create Instance by Property.....");
                        }
                    }
                }
                return dblChkMultiThreadSingleton;
            }
        }
    }
}
