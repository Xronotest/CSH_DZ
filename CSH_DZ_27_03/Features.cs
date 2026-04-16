using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Features
    {
        private String name_ { get; set; }
        private String author_ { get; } = "Publisher";
        private int year_;
        private int lists_;

        public Features()
        {
            name_ = String.Empty;
            author_ = String.Empty;
            year_ = 0;
            lists_ = 0;
        }

        public Features(String name, String author, int year, int lists)
        {
            name_ = name;
            author_ = author;
            year_ = year;
            lists_ = lists;
        }

        public String Info =>
        $"\nНазвание: {name_} \nАвтор: {author_} \nГод выпуска: {year_} \nОбъём в листах: {lists_}";
    }
}
