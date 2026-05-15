using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04_2.Task_1
{
    internal struct ShowFilm
    {
        private string filmName_;
        private int showHall_;
        private string showDate_;
        private string showTime_;
        private int placeCount_;
        private double ticketCost_;

        public string Info 
        {  
            get => 
                "Название: " + filmName_ + 
                "\nЗал: " + showHall_ + 
                "\nДата: " + showDate_ + 
                "\nВремя: " + showTime_ + 
                "\nКол-во мест: " + placeCount_ +
                "\nСтоимсоть билета: " + ticketCost_ + "\n"; 
        }

        public string SeachInfo
        {
            get =>
                "Название: " + filmName_ +
                "Дата: " + showDate_ +
                "Время: " + showTime_;
        }

        public ShowFilm(string filmName, int showHall, string showDate, string showTime, int placeCount, double ticketCost)
        {
            filmName_ = filmName;
            showHall_ = showHall;
            showDate_ = showDate;
            showTime_ = showTime;
            placeCount_ = placeCount;
            ticketCost_ = ticketCost;
        }

        public double Selling(int peoples)
        {
            if (peoples == 0)
            {
                return placeCount_ * ticketCost_;
            }
            else
            {
                return peoples * ticketCost_;
            }
        }

        public double Selling()
        {
            return placeCount_ * ticketCost_;
        }

        public string GetName()
        {
            return filmName_;
        }
    }
}
