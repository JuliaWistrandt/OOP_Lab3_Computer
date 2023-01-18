using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class HDD
    {
        public string model;
        public uint storage;
        public string type;
        public HDD()
        {
            model = "basic RAM name";
            storage = 0;
            type = "basic HDD type";
        }

        public HDD(string model, uint storage, string type)
        {
            this.model = model;
            this.storage = storage;
            this.type = type;

        }

        public override string ToString()
        {
            return $"{model}\nHDD storage: {storage}\nHDD type: {type}";
        }
    }
}
