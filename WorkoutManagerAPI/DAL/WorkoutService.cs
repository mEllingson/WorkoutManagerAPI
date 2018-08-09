using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkoutManagerAPI.DAL
{
    public class WorkoutService
    {
        protected readonly WorkoutContext Context;

        public WorkoutService()
        {
            Context = new WorkoutContext();
        }

        public object GetPrograms()
        {
            return Context.WorkoutProgramTemplates;
        }

        public object GetWorkoutDays(int id)
        {
            return Context.WorkoutDayTemplates.Where(x => x.WorkoutProgramTemplateID == id).Select(x => new
            {
                id = x.ID,
                name = x.Name,
                dayOrder = x.DayOrder
            });

            //return Context.WorkoutDayTemplates.Where(x => x.WorkoutProgramTemplateID == id).Select(x => new
            //{
            //    id = x.ID,
            //    name = x.Name,
            //    dayOrder = x.DayOrder
            //});
            //return Context.WorkoutProgramTemplates.Where(x => x.ID == id).Include(x => x.WorkoutDayTemplates).ToList();
        }

        public object GetWorkoutSets(int id)
        {
            return Context.WorkoutSetTemplates.Include("Exercise").Include("Exercise.ExerciseType").Where(x => x.WorkoutDayTemplateID == id).Select(x => new
            {
                id = x.ID,
                exercise = x.Exercise.Name,
                exerciseType = x.Exercise.ExerciseType.Name,
                reps = x.Repetitions,
                useTM = x.WeightBasedOnTrainingMax,
                tmPercent = x.WeightPercentageOfTrainingMax,
                amrapSet = x.AMRAPSet,
                warmupSet = x.WarmupSet
            }).ToList();

            //return Context.WorkoutDayTemplates.Where(x => x.ID == id).Include(x => x.WorkSetTemplates).ToList();
        }
    }
}