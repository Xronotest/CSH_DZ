using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Humans
    {
        private string _name;
        private int _age;

        public Humans(string name, int age) 
        { 
            _name = name;
            _age = age;
        }

        public virtual string Info()
        {
            return $"\nИнформация: \n" +
                $"Имя: {_name} \n" +
                $"Возраст: {_age} \n";
        }
    }
}
