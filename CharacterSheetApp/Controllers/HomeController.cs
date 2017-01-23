using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
			return View(Models.Character.GetAll();
		}

		public IActionResult Create(string characterName)
		{

			Models.Character.Create(characterName);

			return RedirectToAction("Index");
		}
	}
}