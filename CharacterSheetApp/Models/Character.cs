using System.Collections.Generic;

namespace CharacterSheetApp.Models
{
	public class Character
	{
		public string Name;
		
		// need to write methods to set and retrieve information

		// we are making this method static
		public static void Create(string characterName)
		{
			var character = new Character();
			character.Name = characterName;
			// make sure the Characters List isn't null. Trying to add a character to a null list will return an error.
			if(GlobalVariables.Characters == null)
				GlobalVariables.Characters = new List<Character>();

			// list collections have a .Add() method to use for adding objects to the list.
			GlobalVariables.Characters.Add(character);
		}

		public static List<Character> GetAll()
		{
			// again, need to make sure the variable isn't null.
			if(GlobalVariables.Characters == null)
				GlobalVariables.Characters = new List<Character>();

			return GlobalVariables.Characters;
		}


	}
}