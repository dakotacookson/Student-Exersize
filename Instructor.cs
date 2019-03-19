using System;
using System.Collections.Generic;
namespace studentExercises {
    public class Instructor {

        public Instructor (string firstname, string lastname, string slackHandle, Cohort cohortname) {
            firstName = firstname;
            lastName = lastname;
            slack = slackHandle;
            cohort = cohortname;

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slack { get; set; }
        public Cohort cohort { get; set; }
        public IEnumerable<Student> Students;

        public void asignExercise (Exercise anExercise,Student Student) {
            foreach (Student studentset in Students) {
                studentset.exerciseList.Add(anExercise);
                Console.WriteLine ($"{studentset.firstName} is on  {anExercise.exerciseName}");
            }
        }

    }
}