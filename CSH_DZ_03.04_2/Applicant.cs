namespace CSH_DZ_03._04_2
{
    internal class Applicant
    {
        private string _fio;
        private double _attScore;
        private int _personalScore;
        private string _docDate;

        public Applicant()
        {
            _fio = string.Empty;
            _attScore = 0;
            _personalScore = 0;
            _docDate = string.Empty;
        }

        public Applicant(string fio, double attScore, int personalScore, string docDate)
        {
            _fio = fio;
            _attScore = attScore;
            _personalScore = personalScore;
            _docDate = docDate;
        }

        public string Fio { get { return _fio; } }
        public double Score { get { return _attScore; }}

        public static bool operator >(Applicant left, Applicant right)
        {
            if (left._attScore == right._attScore)
            {
                return left._personalScore > right._personalScore;
            }

            return left._attScore > right._attScore;
        }

        public static bool operator <(Applicant left, Applicant right)
        {
            if (left._attScore == right._attScore)
            {
                return left._personalScore < right._personalScore;
            }

            return left._attScore < right._attScore;
        }
    }
}
