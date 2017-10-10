using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using R2HBook.Models;

namespace R2HBook.Controllers
{
	[Route("roadtohire/[controller]")]
	public class StudentController : Controller
	{
		private readonly StudentContext _context;

		public StudentController(StudentContext context)
		{
			_context = context;

			if (_context.Students.Count() == 0)
			{
				_context.Students.Add(new Student { Name = "Ivan Rosario", Age = 18, Gender = "Male", Path = "Back-End" });
				_context.SaveChanges();
			}
		}

		//Attribute that specifies GET method
		[HttpGet]
		public IEnumerable<Student> GetAll()
		{
			return _context.Students.ToList();
		}

		[HttpGet("{id}", Name = "GetStudent")]
		public IActionResult GetById(int id)
		{
			var item = _context.Students.FirstOrDefault(student => student.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		[HttpPost]
		public IActionResult Create([FromBody] Student student)
		{
			if (student == null)
			{
				return BadRequest();
			}

			_context.Students.Add(student);
			_context.SaveChanges();

			return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
		}

		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Student student)
		{
			if (student == null || student.Id != id)
			{
				return BadRequest();
			}

			var s = _context.Students.FirstOrDefault(t => t.Id == id);
			if (s == null)
			{
				return NotFound();
			}

			s.Name = student.Name;
			s.Age = student.Age;
			s.Gender = student.Gender;
			s.Path = student.Path;

			_context.Students.Update(s);
			_context.SaveChanges();
			return new NoContentResult();
		}
	}

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
	var student = _context.Students.FirstOrDefault(t => t.Id == id);
	if (student == null)
	{
		return NotFound();
	}

	_context.Students.Remove(student);
	_context.SaveChanges();
	return new NoContentResult();
}
    }