using System;
using System.Collections.Generic;

namespace StudentExercise {
        public class Instructor {
                                public Instructor (string Firstname, string Lastename, string Slackhandle, Cohort cohort) {
                        First_Name_ = Firstname;
                        Last_Name_ = Lastename;
                        Slack_Handle_ = Slackhandle;
                        Cohort_id_ = cohort;
                }
                public string First_Name_ { get; set; }
                public string Last_Name_ { get; set; }
                public string Slack_Handle_ { get; set; }
                public Cohort Cohort_id_ { get; set; }
                public int Id { get; set; }

                }
        }