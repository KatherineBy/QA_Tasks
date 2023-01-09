namespace Task_01
{
    internal class SubjectScore
    {
        private int _score;
        public int Score 
        {
            get 
            {
                return _score;
            }
            
            set 
            {
                if(value >= 0 && value <= 100) 
                    _score = value;
            }
        }

        public string SubjectName;

        public SubjectScore(int score, string subjectName)
        {
            Score = score;
            SubjectName = subjectName;
        }

    }
}
