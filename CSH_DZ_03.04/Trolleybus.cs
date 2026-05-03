using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Trolleybus : PublicTransport
    {
        private int _acum;
        public Trolleybus(int num, int count, int speed, int acum) : base(num, count, speed)
        {
            _acum = acum;
        }
        public int Go()
        {
            return (_acum / 200) * 70;
        }

        public override string Info()
        {
            return base.Info() +
                $"Ёмкость аккумулятора: {_acum}\n";
        }
    }
}
