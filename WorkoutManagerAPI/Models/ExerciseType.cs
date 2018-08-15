using System.Collections.Generic;

namespace WorkoutManagerAPI.Models
{
    public class ExerciseType
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}