using Microsoft.AspNetCore.Mvc;
using CharacterSheetApp.Models;

// the name of our app
namespace CharacterSheetApp.Controllers
{
	// class
	public class HomeController : Controller
	{
		// method
		// this method returns an IActionResult, making it an Action Method.
		public IActionResult Index()
		{
			var name = "Hux";
			// we will pass this var to our View as a parameter
			return View("Index", name);
		}
	}
}