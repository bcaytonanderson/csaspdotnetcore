using Microsoft.AspNetCore.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create(string characterName)
		{

			var model = new CharacterSheetApp.Models.Character();
			model.Name = CharacterName;

			// pass the name of the Index view as a parameter to redirect to the index after the model is created.
			return View("Index",model);
		}
	}
}