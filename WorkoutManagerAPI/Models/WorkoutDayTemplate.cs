﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutManagerAPI.Models
{
    public class WorkoutDayTemplate
    {
        public int ID { get; set; }
        public int WorkoutProgramTemplateID { get; set; }        
        public string Name { get; set; }
        public int DayOrder { get; set; }

        public virtual WorkoutProgramTemplate WorkoutProgramTemplate { get; set; }
        public ICollection<WorkoutSetTemplate> WorkSetTemplates { get; set; }
    }
}