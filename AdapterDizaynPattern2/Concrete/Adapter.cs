using AdapterDizaynPattern2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDizaynPattern2.Concrete
{
    public class Adapter : Uyarlayıcı, ITarget
    {
        public string Request(int i)
        {
            return $" Takmini Sonuc:{Math.Round(SpecialRequest(i, 3))}";
        }
    }
}
