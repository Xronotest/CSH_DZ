using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DZ_26._03
{
    public class Task_4
    {
        static public void N_Math(int N)
        {

            int N_ = N;
            int temp;
            int res = 0;
            if (N < 10)
            {
                Console.Write(N);
            }
            else
            {
                while (N_ != 0)
                {
                    temp = N_ % 10;
                    res = (res * 10) + temp;
                    N_ /= 10;
                }
                Console.Write(res);

            }
        }
    }
}
