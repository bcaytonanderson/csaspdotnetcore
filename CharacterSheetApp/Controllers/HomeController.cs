using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

// gives us access to Lambda expressions, which we will use in our CRUD methods.
using System.Linq;

using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Create(Character character)
		{
			_context.Characters.Add(character);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Index()
		{
			// ViewData will pass the title we define here to the title section in the layout.
			ViewData["Title"] = "Characters";
			
			var model = _context.Characters.ToList();

			return View(model);
		}

		public IActionResult GetActive()
		{
			var model = _context.Characters.Where(e => e.IsActive).ToList();

			return View(model);
		}

		public IActionResult Details(string name)
		{
			var model = _context.Characters.FirstOrDefault(e => e.Name == name);

			return View(model);
		}

		public IActionResult Update(Character character)
		{
			_context.Entry(character).State = EntityState.Modified;
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Delete(string name)
		{
			var original = _context.Characters.FirstOrDefault(e => e.Name == name);

			if(original != null)
			{
				_context.Characters.Remove(original);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}