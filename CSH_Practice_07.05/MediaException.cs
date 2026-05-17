using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal class MediaException : Exception
    {
        public MediaException(string message) : base(message)
        {
        }
    }
}
