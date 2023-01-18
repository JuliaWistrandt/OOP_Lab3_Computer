using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class RAM
    {
        public string model;
        public uint storage;
        public RAM()
        {
            model = "basic RAM name";
            storage = 0;
        }

        public RAM(string model, uint storage)
        { 
            this.model = model;
            this.storage = storage;
        
        }

        public override string ToString()
        {
            return $"{model}\nRAM storage: {storage}";
        }
    }
}
