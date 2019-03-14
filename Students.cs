using System;

namespace StudentExercise

{
        public class Student {
                public Student (string Firstname, string Lastename, string Slackhandle, Cohort cohort , Exercise Exercise) {
                        First_Name_ = Firstname;
                        Last_Name_ = Lastename;
                        Slack_Handle_ = Slackhandle;
                        Cohort_id_ = cohort;
                         ExerciseesStudent = Exercise;
                }
                public string First_Name_ { get; set; }
                public string Last_Name_ { get; set; }
                public string Slack_Handle_ { get; set; }
                public Cohort Cohort_id_ { get; set; }
                public Exercise ExerciseesStudent { get; set; }
                public int Id { get; set; }
        }
}