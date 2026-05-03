using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Student : Humans
    {
        private int _course;
        private int _groupNo;

        public Student(string name, int age, int course, int groupNo) : base(name, age)
        {
            _course = course;
            _groupNo = groupNo;
        }

        public override string Info()
        {
            return base.Info() + $"Курс: {_course} \n" +
                $"Номер группы: {_groupNo} \n";
        }
    }
}
