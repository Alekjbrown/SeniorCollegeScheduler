﻿using System;

namespace SeniorCollegeScheduler.Models.ViewModels
{
    public class ClassDetailedViewModel
    {
        //Still need preferred time variables
        public DateTime ProposedDate { get; set; }
        public string ProposedTitle { get; set; }
        
        public int NumClassSessions { get; set; }
        public int LengthOfSession { get; set; }
        public string ClassDesc { get; set; }
        public string PreRequisites { get; set; }
        public int MinStudentCount { get; set; }
        public int MaxStudentCount { get; set; }
        public int TablesNeeded { get; set; }
        public int ChairsNeeded { get; set; }
        public string OtherEquipmentNeeded { get; set; }
        public double HandoutCost { get; set; }
        public bool StipendRequested { get; set; }
    }
}
