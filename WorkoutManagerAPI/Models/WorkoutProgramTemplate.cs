using System.Collections.Generic;

namespace WorkoutManagerAPI.Models
{
    public class WorkoutProgramTemplate
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<WorkoutDayTemplate> WorkoutDayTemplates { get; set; }
    }
}