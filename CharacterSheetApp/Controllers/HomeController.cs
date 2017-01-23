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

			// the method "Index" tells the controller to search for a view called "index.cshtml"
			// public IActionResult Index()
			// {
			// 	var name = "Hux";
			// 	// we will pass this var to our View as a parameter
			// 	return View("Index", name);
			// }

		// once we have some functionality in the Model, we will set the model to a Character object.

		// since the Character model lives outside of the controller, we need to enter the full namespace and class to access it.
		public IActionResult Index()
		{
			var model = new CharacterSheetApp.Models.Character();
			model.Name = "Hux";
			return View(model);
		}
	}
}