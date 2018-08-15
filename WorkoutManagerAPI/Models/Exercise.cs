using System.Collections.Generic;

namespace WorkoutManagerAPI.Models
{
    public class Exercise
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int ExerciseTypeID { get; set; }

        public virtual ExerciseType ExerciseType { get; set; }

        public virtual ICollection<WorkoutSetTemplate> WorkoutSetTemplates { get; set; }
    }
}