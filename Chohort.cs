using System;
using System.Collections.Generic;

namespace StudentExercise {
        public class Cohort {
                public Cohort (string Name) {
                        CohortName = Name;
                }
                public string CohortName { get; set; }
                public Student StudentsInCohort { get; set; }
                public Instructor InstructorsInCohort { get; set; }
                public int Id { get; set; }
        }
}