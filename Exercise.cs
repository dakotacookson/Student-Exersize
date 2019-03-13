using System;

namespace StudentExercise {
        public class Exercise {

                                public Exercise (string Name, string Lang) {
                        Exercise_Name = Name;
                        Exercise_Language_ = Lang;
                }
                public string Exercise_Name { get; set; }
                public string Exercise_Language_ { get; set; }
                public int Id { get; set; }
        }
}