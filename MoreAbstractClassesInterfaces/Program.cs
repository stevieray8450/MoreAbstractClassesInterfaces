using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAbstractClassesInterfaces
{
    abstract class Device
    {
        private string name;

        public Device(string n)
        {
            Name = n;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }   

        public void MainTask(string name)
        {
            Console.WriteLine("Device {0}\'s task implemented here.", name);
        }

        public void MainTask(string name, int i)
        {
            Console.WriteLine("Device {0} has {1} apps installed", name, i);
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

        public void MainTask()
        {
            Console.WriteLine("Trying this method without overriding");
        }

        public Smartphone(string phoneName) : base(phoneName)
        {
            Console.WriteLine("Phone name: {0}", phoneName);
        } 
    }

    class Television
    {
        private string name;
        private int channels;
        private string model;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Equals("Zenith"))
                    Console.WriteLine("That's not a TV, that's a POS");
                else
                {
                    this.name = value;
                }
            }
        } 
        public int Channels
        {
            get { return this.channels; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid channel number. Every television should have at least one channel.");
                }
                else
                {
                    this.channels = value;
                }
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Equals("Samsung"))
                {
                    Console.WriteLine("Samsung!!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public Television()
        { }

        public Television(string tvName, int numChannels, string tvModel)
        {
            this.Name = tvName;
            this.Channels = numChannels;
            this.Model = tvModel;
        }

        public void PrintInfo()
        {
            Console.WriteLine("****TV***** \nName: {0}\nNumber of channels: {1}\nTV Model: {2}", this.Name, this.Channels, this.Model);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Smartphone iPhone2 = new Smartphone("iPhone SE");
            iPhone2.MainTask();
            iPhone2.MainTask(iPhone2.Name);
            ((Device)iPhone2).MainTask(iPhone2.Name, 25);

            Television tv1 = new Television();
            tv1.PrintInfo();
            Television tv2 = new Television("Samsung", 150, "SMARTtv1000");
            tv2.PrintInfo();
        }
    }
}

