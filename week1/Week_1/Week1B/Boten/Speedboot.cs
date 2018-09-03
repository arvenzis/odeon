using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1B.Boten
{
    class Speedboot : Boot
    {
        
        public Speedboot(string naam, int snelheid): this(naam)
        {
            Snelheid = snelheid;
        }

        public Speedboot() : this("geen naam", 0){}

        public Speedboot(string naam) : base(naam){}
    }
}
