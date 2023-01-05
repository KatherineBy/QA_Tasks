using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
