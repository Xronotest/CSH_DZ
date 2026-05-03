using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSH_DZ_03._04
{
    internal class Teacher : Humans
    {
        private int _exp;
        private int _lvl;
        
        public Teacher( string name, int age, int exp, int lvl) : base(name, age)
        {
            _exp = exp;
            _lvl = lvl;
        }

        public int Salary()
        {
            int MPOT = 20000;
            return MPOT + (_exp * 500) + (_lvl * 900);
        }

        public override string Info()
        {
            string _lvlt = "Нет квалификации";
            if (_lvl == 1)
            {
                _lvlt = "Кандидат в доктора наук";
            }
            else if (_lvl == 2)
            {
                _lvlt = "Доктор наук";
            }
            else
            {
                _lvlt = "Нет квалификации";
            }

            return base.Info() + $"Опыт работы: {_exp} \n" +
                $"Уровень квалификации: {_lvlt} \n";
        }
    }
}
