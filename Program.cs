using System;
using System.Collections.Generic;

namespace studentExercises {
    class Program {
        static void Main (string[] args) {

            Instructor Jack = new Instructor ("Jack", "Bright", "@ImortalOne", "C29");
            Instructor Vladimer = new Instructor ("Vladimer", "Obleak", "@SpedyTeach", "C30");
            Instructor nierlethotep = new Instructor ("nierlethotep", "Sigaroth", "@Ancientone", "C28");
            Instructor Jacks = new Instructor ("Jack", "Moris", "@DaddyJack", "C31");

            Cohort cohort28 = new Cohort ("C28");
            Cohort cohort29 = new Cohort ("C29");
            Cohort cohort30 = new Cohort ("C30");
            Cohort cohort31 = new Cohort ("C31");

            cohort28.studentList = new List<Student> ();
            cohort29.studentList = new List<Student> ();
            cohort30.studentList = new List<Student> ();
            cohort31.studentList = new List<Student> ();

            Student Slenish = new Student ("Slenish", "Moris", "@Slenmo", "C29");
            Student Maliker = new Student ("Maliker", "Semor", "@Malikersemor", "C28");
            Student Roxas = new Student ("Roxas", "Sora", "@Soraxis", "C30");
            Student Veronica = new Student ("Veronica", "Sawayer", "@VeronicaSawayer", "C30");
            Student Heather = new Student ("Heather", "Chanler", "@MYTHICB#$%CVH", "C31");

            cohort29.studentList.Add (Slenish);

            cohort28.studentList.Add (Maliker);
            cohort30.studentList.Add (Roxas);

            cohort30.studentList.Add (Veronica);

            cohort31.studentList.Add (Heather);

            List<Exercise> nickExercises = new List<Exercise> ();
            List<Exercise> hunterExercises = new List<Exercise> ();
            List<Exercise> asiaExercises = new List<Exercise> ();
            List<Exercise> jordanExercises = new List<Exercise> ();

            Exercise loops = new Exercise ("SCPS101", "English");
            Exercise headers = new Exercise ("Hunting101", "English");
            Exercise arrays = new Exercise ("Evil101", "English");
            Exercise grids = new Exercise ("Security101", "English");

            List<Instructor> cohort28Instructors = new List<Instructor> ();
            List<Instructor> cohort29Instructors = new List<Instructor> ();
            List<Instructor> cohort30Instructors = new List<Instructor> ();
            List<Instructor> cohort31Instructors = new List<Instructor> ();

            Jack.asignExercise (arrays, cohort28);
            Jack.asignExercise (loops, cohort28);
            Vladimer.asignExercise (arrays, cohort29);
            Vladimer.asignExercise (grids, cohort29);
            nierlethotep.asignExercise (grids, cohort30);
            nierlethotep.asignExercise (headers, cohort30);
            Jacks.asignExercise (arrays, cohort31);
            Jacks.asignExercise (headers, cohort31);

            cohort28Instructors.Add (Jack);
            cohort29Instructors.Add (Vladimer);
            cohort30Instructors.Add (nierlethotep);
            cohort31Instructors.Add (Jacks);

        }
    }
}