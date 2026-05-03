using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class PublicTransport
    {
        private int _num;
        private int _count;
        private int _speed;

        public PublicTransport(int num, int count, int speed)
        {
            _num = num;
            _count = count;
            _speed = speed;
        }

        public virtual string Info()
        {
            return $"\nИнформация: \n" +
                $"Номер: {_num} \n" +
                $"Вместимость: {_count} \n" +
                $"Скорость: {_speed} \n";
        }
    }
}
