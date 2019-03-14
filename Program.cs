using System;
using System.Collections.Generic;
using StudentExercise;
namespace StudentExercise

{
    class Program {
        static void Main (string[] args) {
            Data dataCreator = new Data ();

            Cohort Cohort001 = dataCreator.Cohortset001();

            Exercise SacricRituals = dataCreator.Exersize1 ();
            Exercise Huen = dataCreator.Exersize2 ();
            Exercise ContainmentBreach = dataCreator.Exersize3 ();
            Exercise Dclass = dataCreator.Exersize4 ();

            Student joe = dataCreator.Studentjoe (Cohort001 , ContainmentBreach);
            Student Jaldaboth = dataCreator.StudentJaldaboth(Cohort001 , SacricRituals);
            Student marshal = dataCreator.Studentmarshal (Cohort001 , Huen);



            Instructor DrBright = dataCreator.InstructorBright (Cohort001);
            Instructor DrYoung = dataCreator.Instructoryoung (Cohort001);
            Instructor DrLight = dataCreator.Instructorlight (Cohort001);


        }
    }
}