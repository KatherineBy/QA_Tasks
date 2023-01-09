namespace Task_01
{
    internal class CandidateInfo
    {
        public Person PersonalInfo { get; set; }
        public SubjectScore[] SubjectScores { get; set; }

        public CandidateInfo(Person personalInfo, SubjectScore[] score)
        {
            PersonalInfo = personalInfo;
            SubjectScores = score;

        }

    }
}
