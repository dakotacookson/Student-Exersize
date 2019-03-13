using System;
using System.Collections.Generic;
namespace StudentExercise {
    public class Data {
                public Cohort Cohortset001() {

            Cohort Cohort001 = new Cohort ("chohort 001");
            return Cohort001;
    }
        public Student StudentJaldaboth ( Cohort cohort) {
            Student Jaldaboth = new Student ("Jaldaboth", "of the flesh", "thesarcicone", cohort);
            return Jaldaboth;
        }
        public Student Studentjoe (Cohort cohort) {
            Student Joe = new Student ("Joe", "Shmo", "Bland", cohort);
            return Joe;
        }
        public Student Studentmarshal (Cohort cohort) {
            Student marshal = new Student ("marshal", "Carter", "DARK", cohort);
            return marshal;
        }
        public Exercise Exersize1 () {
            Exercise SacricRituals = new Exercise ("Saricisism 101", "ancient atos");
            return SacricRituals;
        }
        public Exercise Exersize2 () {
            Exercise Huen = new Exercise ("Huen and reality benders", "english");
            return Huen;
        }
        public Exercise Exersize3 () {
            Exercise ContainmentBreach = new Exercise ("What to do incase of a containment", "english");
            return ContainmentBreach;
        }

        public Exercise Exersize4 () {
            Exercise Dclass = new Exercise ("How to handle D-Class", "english");
            return Dclass;
        }
        public Instructor InstructorBright (Cohort cohort) {
            Instructor DrBright = new Instructor ("Jack", "Bright", "TheImortaolDr", cohort);
            return DrBright;
        }
        public Instructor Instructoryoung (Cohort cohort) {
            Instructor DrYoung = new Instructor ("Jane", "Young", "JaneYoungSCP", cohort);
            return DrYoung;
        }
        public Instructor Instructorlight (Cohort cohort)  {
            Instructor DrLight = new Instructor ("Joseph", "Light", "DrLightIsnothere", cohort);
            return DrLight;
        }

    }
}