using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSH_DZ_03._04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¬ведите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            if (userChoise == 1)
            {
                Starter.ApplicantIntz();
            }
            else if (userChoise == 2)
            {
                Starter.DepositCreditIntz();
            }
            else if (userChoise == 3)
            {
                Starter.MatrixIntz();
            }


        }
    }
}
