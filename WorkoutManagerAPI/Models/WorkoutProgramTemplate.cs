using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutManagerAPI.Models
{
    public class WorkoutProgramTemplate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<WorkoutDayTemplate> WorkoutDayTemplates { get; set; }
    }
}