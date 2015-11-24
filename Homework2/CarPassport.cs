using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class CarPassport
    {
        public readonly Car Car;

        public CarPassport()
        {
           
        }

        public CarPassport(Car car)
        {
            Car = car;
        }

        public Driver Owner { get; set; }
    }
}
