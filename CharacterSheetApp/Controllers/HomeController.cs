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

			return View("Index",model);
		}
	}
}