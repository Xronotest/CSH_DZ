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
        
        static private String name_;
        static private String author_;
        static private int year_;
        static private int lists_;

        public Method()
        {
            name_ = String.Empty;
            author_ = String.Empty;
            year_ = 0;
            lists_ = 0;
        }

        public Method(String name, String author, int year, int lists)
        {
            name_ = name;
            author_ = author;
            year_ = year;
            lists_ = lists;
        }


        static public void Info(Method method)
        {
            if (author_ == String.Empty)
            {
                author_ = "Publisher";
            }

             Console.WriteLine($"\nНазвание: {name_} \nАвтор: {author_} \nГод выпуска {year_} \nОбъём в листах: {lists_}");
        }
      
    }
}
