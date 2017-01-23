using System.Collections.Generic;

namespace CharacterSheetApp.Models
{
	public class Character
	{
		public string Name;

		public static void Create(string characterName)
		{
			var character = new Character();
			character.Name = characterName;

			// no longer need this since we set a default value in GlobalVariabels.cs
			// if(GlobalVariables.Characters == null)
			// 	GlobalVariables.Characters = new List<Character>();

			GlobalVariables.Characters.Add(character);
		}

		public static List<Character> GetAll()
		{
			// if(GlobalVariables.Characters == null)
			// 	GlobalVariables.Characters = new List<Character>();

			return GlobalVariables.Characters;
		}


	}
}