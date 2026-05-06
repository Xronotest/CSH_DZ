namespace CSH_DZ_03._04_2
{
    internal class Deposit
    {
        private string _fio;
        private double _sum;
        private static double _interestRate = 10;

        public Deposit()
        {
            _fio = string.Empty;
            _sum = 0;
        }

        public Deposit(string fio, double sum)
        {
            _fio = fio;
            _sum = sum;
        }

        public string Fio { get { return _fio; } }
        public double Sum { get { return _sum; } }

        public static double InterestRate()
        {
            return _interestRate;
        }

        public static Deposit operator ++(Deposit deposit)
        {
            deposit._sum += deposit._sum * _interestRate / 100;

            return deposit;
        }
    }
}
