namespace CSH_DZ_03._04_2
{
    internal static class Admission
    {
        private const double needScore = 4.5;

        public static bool ScoreCheck(Applicant applicant)
        {
            return applicant.Score >= needScore;
        }
    }
}
