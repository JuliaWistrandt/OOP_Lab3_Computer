using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class HDDFactory : IHDDCreatable
    {
        public HDD CreateHDD() 
        {
            return new HDD() {model = "HDDFactory name" };
        }
    }
}
