namespace CSH_DZ_03._04_2
{
    internal class Credit
    {
        private string _fio;
        private double _paymentSum;
        private static double _interestRate = 15;

        public Credit()
        {
            _fio = string.Empty;
            _paymentSum = 0;
        }

        public Credit(string fio, double paymentSum)
        {
            _fio = fio;
            _paymentSum = paymentSum;
        }

        public string Fio { get { return _fio; } }
        public double PaymentSum { get { return _paymentSum; } }

        public static double InterestRate()
        {
            return _interestRate;
        }

        public static double operator -(Deposit deposit, Credit credit)
        {
            return deposit.Sum - credit._paymentSum;
        }
    }
}
