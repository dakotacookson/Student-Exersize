using System;
using System.Collections.Generic;
namespace StudentExercise {
    public class Data {
                public Cohort Cohortset001() {

            Cohort Cohort001 = new Cohort ("chohort 001");
            return Cohort001;
    }
        public Student StudentJaldaboth ( Cohort cohort , Exercise Exercise ) {
            Student Jaldaboth = new Student ("Jaldaboth", "of the flesh", "thesarcicone", cohort , Exercise);
            return Jaldaboth;
        }
        public Student Studentjoe (Cohort cohort , Exercise Exercise) {
            Student Joe = new Student ("Joe", "Shmo", "Bland", cohort , Exercise);
            return Joe;
        }
        public Student Studentmarshal (Cohort cohort , Exercise Exercise) {
            Student marshal = new Student ("marshal", "Carter", "DARK", cohort , Exercise);
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