using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WorkoutManagerAPI.DAL;
using WorkoutManagerAPI.Models;

namespace WorkoutManagerAPI.Controllers
{
    public class WorkoutController : ApiController
    {
        private readonly WorkoutService service;

        public WorkoutController()
             : this(new WorkoutService())
        {
        }

        public WorkoutController(WorkoutService service)
        {
            this.service = service;
        }

        public Object GetPrograms()
        {
            return new { Programs = service.GetPrograms() };
        }

        public Object GetProgramDays(int id)
        {

            return new { ProgramDays = service.GetWorkoutDays(id) };
        }

        public Object GetProgramDaySets(int id)
        {
            return new { ProgramDaySets = service.GetWorkoutSets(id) };
        }
     
    }
}