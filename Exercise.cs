using System;

namespace studentExercises {
    public class Exercise {
        public Exercise (string exercise, string language) {
            exerciseName = exercise;
            exerciseLanguage = language;
        }
        public string exerciseName { get; set; }
        public string exerciseLanguage { get; set; }

    }
}