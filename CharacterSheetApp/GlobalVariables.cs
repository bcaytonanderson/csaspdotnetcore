// "Using Directives"
using System.Collections.Generic;
using CharacterSheetApp.Models;

namespace CharacterSheetApp
{
	public static class GlobalVariables
	{
		// adding a get setter to a field or variable changes it into a property

		// adding the = new line to this will set a default value. So in the event that our list is null, it'll use whatever is set after the = as the default value.
		public static List<Character> Characters { get; set; }
			= new List<Character>();
	}
}