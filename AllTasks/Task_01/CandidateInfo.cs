namespace Task_01
{
    internal class CandidateInfo
    {
        public Person PersonalInfo;
        public SubjectScore[] SubjectScores;

        public CandidateInfo(Person personalInfo, SubjectScore[] score)
        {
            PersonalInfo = personalInfo;
            SubjectScores = score;

        }

    }
}
