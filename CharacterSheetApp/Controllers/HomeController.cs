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

			// instead of returning a view, this RedirectToAction will take us to the Index action in the Home controller. This will prevent the user from accidentally saving the same character twice by refreshing, avoids duplicate code.
			return RedirectToAction("Index");
		}
	}
}