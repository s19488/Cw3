using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.DAL;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class ŚtudentsController : ControllerBase
    {
        private readonly iDbService _dbService;

        public ŚtudentsController(iDbService dbService)
        {
            _dbService = dbService;
        }

       [HttpGet]
       public IActionResult GetStudents(string orederBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPut]
        public IActionResult PutStudents(string orederBy)
        {
            return Ok("200");
        }

        [HttpDelete]
        public IActionResult DeleteStudents(string orederBy)
        {
            return Ok("aktualizacja zakonczona");
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if(id==1)
            {
                return Ok("Kowalski");
            }else if(id==2)
            {
                return Ok("Malewski");
            }
            return NotFound("Nie znaleziono Studenta");
        }
        [HttpPost]

        public IActionResult CreateStudent(Śtudent student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

    }
}