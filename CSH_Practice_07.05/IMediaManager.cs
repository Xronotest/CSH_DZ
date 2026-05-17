using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal interface IMediaManager<T>
    {
        void Add(T item);
        bool Remove(string title);
        T FindByTitle(string title);
        IEnumerable<T> FilterByYear(int year);
        IEnumerable<T> GetAllAvailable();
    }
}
