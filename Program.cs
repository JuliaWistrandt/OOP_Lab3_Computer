using System;

namespace Computer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computerList = new List<Computer>()
            {
                new Computer(new SgateHDDFactory()),
                new Computer(new HDDFactory()),
                new Computer(new HDD()),
                new Computer(9999, "Apple"),
                new Computer(1000.95, "Samsung Gaming Edition", new HDD("WD Blue", 1, "External"), new RAM("DDR4", 16))

            };

            Console.WriteLine("Total ammount of computers in our shop is: " + computerList.Count);
            foreach(var comp in computerList) Console.WriteLine(comp.GetDetailedInfo());
            




        }
    }
}