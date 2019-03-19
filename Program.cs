using System;
using System.Collections.Generic;

namespace studentExercises {
    class Program {
        static void Main (string[] args) {


            Cohort cohort28 = new Cohort ("C28");
            Cohort cohort29 = new Cohort ("C29");
            Cohort cohort30 = new Cohort ("C30");
            Cohort cohort31 = new Cohort ("C31");

            Instructor Jack = new Instructor ("Jack", "Bright", "@ImortalOne", cohort29);
            Instructor Vladimer = new Instructor ("Vladimer", "Obleak", "@SpedyTeach", cohort30);
            Instructor nierlethotep = new Instructor ("nierlethotep", "Sigaroth", "@Ancientone", cohort28);
            Instructor Jacks = new Instructor ("Jack", "Moris", "@DaddyJack", cohort31);




            Student Slenish = new Student ("Slenish", "Moris", "@Slenmo", cohort29);
            Student Maliker = new Student ("Maliker", "Semor", "@Malikersemor", cohort28);
            Student Roxas = new Student ("Roxas", "Sora", "@Soraxis", cohort30);
            Student Veronica = new Student ("Veronica", "Sawayer", "@VeronicaSawayer", cohort30);
            Student Heather = new Student ("Heather", "Chanler", "@MYTHICB#$%CVH", cohort31);

            cohort29.studentList.Add (Slenish);

            cohort28.studentList.Add (Maliker);
            cohort30.studentList.Add (Roxas);

            cohort30.studentList.Add (Veronica);

            cohort31.studentList.Add (Heather);

            List<Exercise> nickExercises = new List<Exercise> ();
            List<Exercise> hunterExercises = new List<Exercise> ();
            List<Exercise> asiaExercises = new List<Exercise> ();
            List<Exercise> jordanExercises = new List<Exercise> ();

            Exercise SCPS101 = new Exercise ("SCPS101", "English");
            Exercise Hunting101 = new Exercise ("Hunting101", "English");
            Exercise Evil101 = new Exercise ("Evil101", "English");
            Exercise Security101 = new Exercise ("Security101", "English");

            List<Instructor> cohort28Instructors = new List<Instructor> ();
            List<Instructor> cohort29Instructors = new List<Instructor> ();
            List<Instructor> cohort30Instructors = new List<Instructor> ();
            List<Instructor> cohort31Instructors = new List<Instructor> ();

            Jack.asignExercise (Evil101, Heather);
            Jack.asignExercise (SCPS101, Slenish);
            Vladimer.asignExercise (Evil101, Veronica);
            Vladimer.asignExercise (Security101, Heather);
            nierlethotep.asignExercise (Security101, Maliker);
            nierlethotep.asignExercise (Hunting101, Roxas);
            Jacks.asignExercise (Evil101, Veronica);
            Jacks.asignExercise (Hunting101, Slenish);

            cohort28Instructors.Add (Jack);
            cohort29Instructors.Add (Vladimer);
            cohort30Instructors.Add (nierlethotep);
            cohort31Instructors.Add (Jacks);

        }
    }
}