using System;

namespace studentExercises {
    public class Instructor {
        public Instructor (string firstname, string lastname, string slackHandle, string cohortname) {
            firstName = firstname;
            lastName = lastname;
            slack = slackHandle;
            cohort = cohortname;

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slack { get; set; }
        public string cohort { get; set; }

        public void asignExercise (Exercise anExercise, Cohort students) {
            foreach (Student student in students.studentList) {
                student.exerciseList.Add (anExercise);
                Console.WriteLine ($"{student.firstName} is on  {anExercise.exerciseName}");
            }
        }

    }
}