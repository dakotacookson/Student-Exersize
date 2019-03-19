using System;
using System.Collections.Generic;

namespace studentExercises
{
    public class Student
    {
        public Student (string firstname, string lastname, string slackHandle, string cohortnameame )
        {
            firstName = firstname;
            lastName = lastname;
            slack = slackHandle;
            cohort = cohortnameame;
            exerciseList = new List<Exercise>();
        }
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string slack {get; set;}
        public string cohort {get; set;}

        public List<Exercise> exerciseList {get; set;}


    }
}
