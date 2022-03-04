using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Domain.DTO.Student;
using SchoolApi.Services.Interfaces;

namespace SchoolApi.Application.Controller
{
    public class StudentsController : BaseApiController
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _studentService.GetAll());
            }
            catch (System.Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("getById/{id}", Name = "GetById")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                if(id == Guid.Empty)
                    return BadRequest("ID must not be null or empty");

                var student = await _studentService.GetById(id);

                if(student == null)
                    return NotFound("Student not found");
                else
                    return Ok(student);
            }
            catch (System.Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateStudentDto model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var student = await _studentService.Post(model);

                    if(student != null)
                        return Created(new Uri(Url.Link("GetById", new { id = student.Id })), student);

                    return BadRequest();
                }
                else
                {
                    return UnprocessableEntity(ModelState);
                }
            }
            catch (System.Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateStudentDto model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var student = await _studentService.Put(model);

                    if(student != null)
                        return Created(new Uri(Url.Link("GetById", new { id = student.Id })), student);

                    return BadRequest();
                }
                else
                {
                    return UnprocessableEntity(ModelState);
                }
            }
            catch (System.Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                if(id != Guid.Empty)
                {
                    var result = await _studentService.Delete(id);

                    if(result)
                        return NoContent();

                    return BadRequest();
                }
                else
                {
                    return BadRequest("ID must not be null or empty");
                }
            }
            catch (System.Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}