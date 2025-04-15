using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentApi.DataStimulation;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(DataStimulus.Students);
        }

        [HttpGet("Passed", Name = "GetPassedStudents")]
        public ActionResult<IEnumerable<Student>> GetPassedStudents()
        {
            var passedStudents = DataStimulus.Students.Where(s => s.Grade >= 50);
            return Ok(passedStudents);
        }

    }
}
