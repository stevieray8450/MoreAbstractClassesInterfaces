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
        public void Type()
        {
            Console.WriteLine("Type type type");
        }

        public void Text()
        {
            Console.WriteLine("Texting");
        }

        public void Send()
        {
            Console.WriteLine("Sending a text");
        }

        public void Call()
        {
            Console.WriteLine("Placing a call");
        }

        public void Answer()
        {
            Console.WriteLine("Answering inbound call");
        }

        public Smartphone()
        {
            private string name;
            private string description;
            private string manufacturer;
            private int numOfInputs;
            private bool hasScreen;
            private bool isHandHeld;
            private bool hasBattery;
            private bool isInternetEnabled;


    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
