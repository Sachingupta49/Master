using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTonImp();
        }

        static void SingleTonImp()
        {
            // Standared Implementation method
            StandSingleton.GetInstanceMethod();
            // Standared Implementation Propery
            StandSingleton objStand = StandSingleton.GetInstancePropperty;

            //Multithreading Singleton Implementation Property
            MultiThreadSingleton objMulti = MultiThreadSingleton.GetInstancePropery;
            //Multithreading Singleton Implementation Method
            MultiThreadSingleton.GetInstanceMethod();

            //Double Check Multithreading Singleton Implementation Method
            DblChkMultiThreadSingleton.GetInstanceMethod();
            //Double Check Multithreading Singleton Implementation Method
            DblChkMultiThreadSingleton objDblChkMulti = DblChkMultiThreadSingleton.GetInstanceProperty;

            //Early Instance Singleton Implementation Property
            EarlySingleton objEarlySing = EarlySingleton.GetInstanceProperty;
            //Early Instance Singleton Implementation Method
            EarlySingleton.GetInstanceMethod();
        }
    }
}
