using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAbstractClassesInterfaces
{
    abstract class Device
    {
        string name;
        string description;
        string manufacturer;
        int numOfInputs;
        bool hasScreen;
        bool isHandHeld;
        bool hasBattery;
        bool isInternetEnabled;
        
        public virtual void MainTask(string name)
        {
            Console.WriteLine("Device {0}\'s task implemented here.", name);
        }
    }

    interface IText
    {
        void Type();
        void Text();
        void Send();
    } 

    interface ICall
    {
        void Call();
        void Answer();
    }

    interface IPrint
    {
        void Print();
    }

    class Smartphone : Device, IText, ICall
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
