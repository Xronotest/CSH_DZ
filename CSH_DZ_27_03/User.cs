using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class User
    {
        static private String surname_;
        static private String name_;
        static private String patronymic_;
        static private int age_;

        public User()
        {
            surname_ = String.Empty;
            name_ = String.Empty;
            patronymic_ = String.Empty;
            age_ = 0;
        }

        public User(String surname, String name, String patronymic, int age)
        {
            surname_ = surname;
            name_ = name;
            patronymic_ = patronymic;
            age_ = age;

        }

        static public void Fio(User human)
        {
            StringBuilder fio = new StringBuilder();
            fio.Append(surname_ + " " + name_ + " " + patronymic_);
            Console.WriteLine(fio.ToString());
        }
    }
}
