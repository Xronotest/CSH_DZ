using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Bus : PublicTransport
    {
        private int _fuel;
        public Bus(int num, int count, int speed, int fuel) : base(num, count, speed)
        {
            _fuel = fuel;
        }

        public int Go()
        {
            return (_fuel / 20) * 25;
        }

        public override string Info()
        {
            return base.Info() +
                $"Вместимость бензобака: {_fuel}\n";
        }
    }
}
