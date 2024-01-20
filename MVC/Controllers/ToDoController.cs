using System;
using Microsoft.AspNetCore.Mvc;
using MVC.Data;

namespace MVC.Controllers
{
	public class ToDoController : Controller 
	{
		private readonly ApplicationDbContext _context;
        public ToDoController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var todo = _context.ToDos.ToList();

			return View(todo);
		}
	}
}

