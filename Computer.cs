using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Computer 
{
    // class HDD, RAM and Computer are an example of composition 
    public class Computer
    {
        public  double price;
        string model;
        public HDD hdd;
        public RAM ram;

        //constructor 
        public Computer(double price, string model)
        {
            this.price = price;
            this.model = model;
            hdd = new HDD();
            ram = new RAM();
        }

        public Computer(double price, string model, HDD hdd, RAM ram)
        {
            this.price = price;
            this.model = model;
            this.hdd = new HDD();
            this.ram = new RAM();
        }

        public Computer(IHDDCreatable factory)
        {
            this.price = 100;
            this.hdd = factory.CreateHDD();
            this.ram = new RAM();
        }

        public Computer(HDD hdd)
        {
            this.price = 200;
            this.hdd = hdd;
            this.ram = new RAM();
        }

        public string GetDetailedInfo()
        {
            return $"\nModel: {model}\nPrice: {price}\nHDD: {hdd}\nRAM: {ram}\n";
        
        }

    }

}
