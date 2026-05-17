using CSH_Practice_07._05.MediaItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal static class LibraryLinqExtensions
    {
        public static IEnumerable<Book> BooksAfter(this Library<Book> library, int year)
        {
            return library.GetAll()
                .Where(book => book.YearPublished > year);
        }

        public static IEnumerable<Movie> MovieSortDuration(this Library<Movie> library)
        {
            return library.GetAll()
                .OrderBy(movie => movie.Duration);
        }
    }
}
