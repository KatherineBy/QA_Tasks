using Task_01;

internal class Program
{
    private static void Main(string[] args)
    {

        const string SUBJECT = "Literature";

        CandidateInfo candidate1 = new (
            new Person("Maxim", "Maximov",
                new Address(160, 14, "Kurkowa", "Wroclaw")),
                    new SubjectScore[] {
                        new SubjectScore(40, "Math"),
                        new SubjectScore(50, "Physics"),
                        new SubjectScore(80, "Literature"),
                        new SubjectScore(90, "Language")
                    });


        CandidateInfo candidate2 = new (
            new Person("Renat", "Renatov",
                new Address(12, 5, "Wloska", "Warsaw")),
                    new SubjectScore[] {
                        new SubjectScore(100, "Math"),
                        new SubjectScore(90, "Physics"),
                        new SubjectScore(50, "Literature"),
                        new SubjectScore(20, "Language")
                    });

        CandidateInfo candidate3 = new (
            new Person("Mark", "Markov",
                new Address(45, 67, "Minska", "Krakow")),
                    new SubjectScore[] {
                        new SubjectScore(70, "Math"),
                        new SubjectScore(65, "Physics"),
                        new SubjectScore(75, "Literature"),
                        new SubjectScore(67, "Language")
                    });

        CandidateInfo candidate4 = new (
            new Person("Oleg", "Olegov",
                new Address(10, 3, "Swobodna", "Poznan")),
                    new SubjectScore[] {
                        new SubjectScore(87, "Math"),
                        new SubjectScore(46, "Physics"),
                        new SubjectScore(55, "Literature"),
                        new SubjectScore(60, "Language")
                    });

        CandidateInfo candidate5 = new (
            new Person("Petr", "Petrov",
                new Address(45, 46, "Witolda", "Gdansk")),
                    new SubjectScore[] {
                        new SubjectScore(50, "Math"),
                        new SubjectScore(35, "Physics"),
                        new SubjectScore(68, "Literature"),
                        new SubjectScore(78, "Language")
                    });


        CandidateInfo[] CandidatesList = { candidate1, candidate2, candidate3, candidate4, candidate5 };


        // to show all streets

        foreach (CandidateInfo candidate in CandidatesList)
        {
            Console.WriteLine(candidate.PersonalInfo.Address.Street);
        }


        // to show max mark on SUBJECT

        int maxMark = -1;
        foreach (CandidateInfo candidate in CandidatesList)
        {
            foreach (var item in candidate.SubjectScores)
            {
                if (item.SubjectName == SUBJECT && item.Score > maxMark)
                {
                    maxMark = item.Score;
                }
            }
        }    
        
        Console.WriteLine($"The highest mark on {SUBJECT} is {maxMark}");

      

    }
}

