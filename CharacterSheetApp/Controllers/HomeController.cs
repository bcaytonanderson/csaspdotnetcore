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
		// this adds a new variable for our ApplicationDbContext class named _context
		private readonly ApplicationDbContext _context;

		public HomeController(ApplicationDbContext context)
		{
			// we will set our readonly variable to the variable passed in to the method. This is known as a Construction Injection. Injects ApplicationDbContext into our controller.
			_context = context;
		}

		public IActionResult Create(Character character)
		{
			_context.Characters.Add(character);
			// commits the changes to the DB:
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Index()
		{
			// .ToList() takes our db collection into a List collection.
			var model = _context.Characters.ToList();
			return View(model);
		}

		public IActionResult GetActive()
		{
			// the .Where() method accepts a LAMBDA EXPRESSION (e.g., e => . . . ) which checks for any record in the collection that returns true for what we are looking for.
			var model = _context.Characters.Where(e => e.IsActive).ToList();
			return View(model);
		}

		public IActionResult Details(string name)
		{
			// .FirstOrDefault() returns a single result, rather than a collection. The lambda expression here checks for a record that has a name which matches the input name.
			var model = _context.Characters.FirstOrDefault(e => e.Name == name);
			return View(model);
		}

		public IActionResult Update(Character character)
		{
			// to update a record, we can use Entity to locate and set our data, then set its State to Modified, letting the EntityFramework know we have changed this record.
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