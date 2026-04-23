using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class User
    {
        private string _surname;
        private string _name;
        private string _patronymic;
        private int _age;

        public User()
        {
            _surname = string.Empty;
            _name = string.Empty;
            _patronymic = string.Empty;
            _age = 0;
        }

        public User(string surname, string name, string patronymic, int age)
        {
            _surname = surname;
            _name = name;
            _patronymic = patronymic;
            _age = age;

        }

        public void Fio(User human)
        {
            StringBuilder fio = new StringBuilder();
            fio.Append(_surname + " " + _name + " " + _patronymic);
            Console.WriteLine(fio.ToString());
        }
    }
}
