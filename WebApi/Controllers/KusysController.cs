using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KusysController : ControllerBase
    {
        private IStudentService _studentService;
        private ICourseService _courseService;
        private ICourseMatchService _courseMatchService;
        public KusysController(IStudentService studentService, ICourseService courseService, ICourseMatchService courseMatchService)
        {
            _studentService = studentService;
            _courseService = courseService;
            _courseMatchService = courseMatchService;
        }

        [HttpGet("getStudentList")]
        public async Task<IActionResult> GetStudentList()
        {
            return Ok(await _studentService.GetList());
        }

        [HttpGet("getStudentById")]
        public async Task<IActionResult> GetStudentById([FromQuery] int id)
        {
            return Ok(await _studentService.GetById(id));
        }

        [HttpPost("addStudent")]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            return Ok(await _studentService.Add(student));
        }

        [HttpPost("updateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] Student student)
        {
            return Ok(await _studentService.Update(student));
        }

        [HttpPost("deleteStudent")]
        public async Task<IActionResult> DeleteStudent([FromBody] Student student)
        {
            return Ok(await _studentService.Delete(student));
        }

        [HttpGet("getStudentDetail")]
        public async Task<IActionResult> GetStudentDetail([FromQuery] int studentId)
        {
            return Ok(await _studentService.GetStudentDetail(studentId));
        }

        [HttpGet("getCourseList")]
        public async Task<IActionResult> GetCourseList()
        {
            return Ok(await _courseService.GetList());
        }

        [HttpPost("addMatch")]
        public async Task<IActionResult> AddMatch([FromBody] CourseMatch match)
        {
            return Ok(await _courseMatchService.Add(match));
        }
    }
}