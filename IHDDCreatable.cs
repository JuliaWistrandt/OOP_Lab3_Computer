using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public interface IHDDCreatable
    {
        HDD CreateHDD()
        {
            return new HDD() { model = "IHDDCreatable name" };
        }
    }
}
