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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(DataStimulus.Students);
        }


        [HttpGet("Passed", Name = "GetPassedStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Student>> GetPassedStudents()
        {
            var passedStudents = DataStimulus.Students.Where(s => s.Grade >= 50);
            return Ok(passedStudents);
        }


        [HttpGet("Average", Name = "GetAvgGradeStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<double> GetAvgGradeStudents()
        {
            var avgGrade = DataStimulus.Students.Average(s => s.Grade);
            return Ok(avgGrade);
        }


        [HttpGet("{id}", Name = "GetStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Student> GetStudentById(int id)
        {
            var student = DataStimulus.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound("Student You Requested Is Not Found!");

            return Ok(student);
        }


        [HttpPost(Name = "AddNewStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Student> AddNewStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
                return BadRequest($"Student name should not be empty");

            if (student.Age <= 0)
                return BadRequest($"Age must be greater than 0");

            if (student.Grade < 0)
                return BadRequest("Grade must be 0 or greater");

            student.Id = 5;
            DataStimulus.Students.Add(student);

            return CreatedAtRoute("GetStudentById", new { id = student.Id }, student);
        }


        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteStudent(int id)
        {
            if (id <= 0)
                return BadRequest("Student ID must be greater than 0");

            var student = DataStimulus.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student was not found");

            DataStimulus.Students.Remove(student);

            return Ok("Student Deleted Successfully");
        }


        [HttpPut("{id}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Student> UpdateStudent(int id, Student updatedStudent)
        {
            if (id <= 0)
                return BadRequest("Student ID must be greater than 0");

            if (string.IsNullOrEmpty(updatedStudent.Name))
                return BadRequest($"Student name should not be empty");

            if (updatedStudent.Age <= 0)
                return BadRequest($"Age must be greater than 0");

            if (updatedStudent.Grade < 0)
                return BadRequest("Grade must be 0 or greater");


            var student = DataStimulus.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student was not found");

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Grade = updatedStudent.Grade;

            return Ok(student);
        }

    }
}