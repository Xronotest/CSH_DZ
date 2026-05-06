using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04_2
{
    internal class Starter
    {
        public static void ApplicantIntz()
        {
            Applicant applicant1 = new Applicant();
            Applicant applicant2 = new Applicant();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Созданеи {i + 1} Абитуриента");
                Console.Write("Введите ФИО: ");
                string fio = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Средний балл: ");
                double attScore = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Баллы за личные достижения: ");
                int personalScore = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Дату подачи документов: ");
                string docDate = Convert.ToString(Console.ReadLine());
                if (i == 0)
                {
                    applicant1 = new Applicant(fio, attScore, personalScore, docDate);
                }
                else
                {
                    applicant2 = new Applicant(fio, attScore, personalScore, docDate);
                }
            }

            if (applicant1 > applicant2)
            {
                Console.WriteLine($"{applicant1.Fio} первосходит {applicant2.Fio}");
            }
            else if (applicant1 < applicant2)
            {
                Console.WriteLine($"{applicant2.Fio} первосходит {applicant1.Fio}");
            }
            else { Console.WriteLine("Они равны"); }

            if (Admission.ScoreCheck(applicant1))
            {
                Console.WriteLine($"{applicant1.Fio} сможет поступить");
            }
            else
            {
                Console.WriteLine($"{applicant1.Fio} не сможет поступить");
            }

            if (Admission.ScoreCheck(applicant2))
            {
                Console.WriteLine($"{applicant2.Fio} сможет поступить");
            }
            else
            {
                Console.WriteLine("Второй абитуриент не сможет поступить");
            }
        }

        public static void DepositCreditIntz()
        {
            Deposit deposit = new Deposit();
            Credit credit = new Credit();


            Console.WriteLine($"Создание Вклада");
            Console.Write("Введите ФИО вкладчика: ");
            string fio = Convert.ToString(Console.ReadLine());
            Console.Write("Введите Сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            deposit = new Deposit(fio, sum);

            Console.WriteLine($"Создание Кредита");
            Console.Write("Введите ФИО вкладчика: ");
            string fioCred = Convert.ToString(Console.ReadLine());
            Console.Write("Введите Сумму платежа: ");
            double paymentSum = Convert.ToDouble(Console.ReadLine());
            credit = new Credit(fioCred, paymentSum);


            Console.WriteLine($"Процентная ставка вклада: {Deposit.InterestRate()}%");
            Console.WriteLine($"Процентная ставка кредита: {Credit.InterestRate()}%");

            deposit++;
            Console.WriteLine($"Влад {deposit.Fio} был увеличен до {deposit.Sum}");

            if (deposit.Fio == credit.Fio)
            {
                Console.WriteLine($"Вклад:{deposit.Fio} \n" + $"Платеж по кредиту = {credit.PaymentSum} \n" + $"Остаток: {deposit - credit}");
            }
            else
            {
                Console.WriteLine($"Вклад:{deposit.Fio} \n" + $"Платеж за кредит пользователя {credit.Fio} = {credit.PaymentSum} \n" + $"Остаток: {deposit - credit}");
            }


        }

        public static void MatrixIntz()
        {
            

            Console.Write("Введите кол-во строк: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Создание первой матрицы: ");
            Matrix mat1 = new Matrix(row, col);
            Console.WriteLine("Создание второй матрицы: ");
            Matrix mat2 = new Matrix(row, col);

            Console.WriteLine($"Первая матрица:\n{mat1.PrintMatrix()}");
            Console.WriteLine($"Вторая матрица:\n{mat2.PrintMatrix()}");

            Console.WriteLine($"Результат умножения матриц:\n{(mat1 * mat2).PrintMatrix()}");
            Console.WriteLine($"Результат умножения первой матрицы на число:\n{(mat1 * num).PrintMatrix()}");
            Console.WriteLine($"Результат умножения второй матрицы на число:\n{(num * mat2).PrintMatrix()}");
            Console.WriteLine($"Результат сложения матриц:\n{(mat1 + mat2).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания второй матрицы из первой матрицы:\n{(mat1 - mat2).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания первой матрицы из второй матрицы:\n{(mat2 - mat1).PrintMatrix()}");
            Console.WriteLine($"Результат сложения первой матрицы и числа:\n{(mat1 + num).PrintMatrix()}");
            Console.WriteLine($"Результат сложения второй матрицы и числа:\n{(num + mat2).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания числа из первой матрицы:\n{(mat1 - num).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания числа из второй матрицы:\n{(mat2 - num).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания первой матрицы из числа:\n{(num - mat1).PrintMatrix()}");
            Console.WriteLine($"Результат вычитания второй матрицы из числа:\n{(num - mat2).PrintMatrix()}");

            if (mat1 > mat2)
            {
                Console.WriteLine("Первая матрица больше второй");
            }
            else if (mat1 < mat2)
            {
                Console.WriteLine("Вторая матрица больше первой");
            }
            else
            {
                Console.WriteLine("Матрицы равны или не сравнимы");
            }
        }
    }
}
