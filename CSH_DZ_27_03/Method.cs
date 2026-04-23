using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Method
    {
        
        private String _name;

        public string GetName()
        {
            return _name;
        }


        public void SetName(string value)
        {
            _name = value;
        }
        private String _author;

        public string GetAuthor()
        {
            return _author;
        }
        private int _year;
        private int _lists;
        private string _publisher;

        public string GetPublisher()
        {
            return _publisher;
        }

        public void SetPublisher(string value)
        {
            _publisher = value;
        }

        public Method()
        {
            _author = String.Empty;
            _year = 0;
            _lists = 0;
        }

        public Method(String author, int year, int lists)
        {
            _author = author;
            _year = year;
            _lists = lists;
        }


        public void Info(Method method)
        {
             Console.WriteLine($"\nНазвание: {GetName} \nАвтор: {GetAuthor} \nГод выпуска {_year} \nОбъём в листах: {_lists} \nИздательство: {GetPublisher}");
        }
      
    }
}
