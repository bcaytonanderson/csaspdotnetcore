using Microsoft.AspNetCore.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		var model = new CharacterSheetApp.Models.Character();
		model.Name = "Hux";
		return View(model);
	}
}