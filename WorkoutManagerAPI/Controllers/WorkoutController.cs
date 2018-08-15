using System;
using System.Threading.Tasks;
using System.Web.Http;
using WorkoutManagerAPI.DAL;

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

        public async Task<object> GetPrograms()
        {
            return new { Programs = await this.service.GetPrograms() };
        }

        public async Task<object> GetProgramDays(int id)
        {
            return new { ProgramDays = await this.service.GetWorkoutDays(id) };
        }

        public async Task<object> GetProgramDaySets(int id)
        {
            return new { ProgramDaySets = await this.service.GetWorkoutSets(id) };
        }     
    }
}