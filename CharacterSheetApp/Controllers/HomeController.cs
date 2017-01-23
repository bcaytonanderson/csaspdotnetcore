using Microsoft.AspNetCore.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
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