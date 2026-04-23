using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Features
    {
        private string _name;

        public string Name { get { return _name; } set { _name = value; } }
        private String _author;

        public string Autor { get { return _author; } }
        private int _year;
        private int _lists;

        public Features()
        {
            _author = String.Empty;
            _year = 0;
            _lists = 0;
        }

        public Features(String author, int year, int lists)
        {
            _author = author;
            _year = year;
            _lists = lists;
        }

        public String Publisher { get; set; }
       

        public String Info { get { return "\nНазвание: " + Name + "\nАвтор: " + Autor + "\nГод выпуска: " + _year + "\nОбъём в листах: " + _lists + "\nИздательство: " + Publisher; } }
    }
}
