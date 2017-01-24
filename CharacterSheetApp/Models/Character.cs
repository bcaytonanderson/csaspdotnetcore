using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterSheetApp.Models
{
	public class Character
	{
		public string Name { get; set; }

		[Display(Name = "Is Active")]
		public bool IsActive  { get; set; }
		public int Level  { get; set; }
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Intelligence  { get; set; }

		public List<Equipment> Equipment { get; set; }
	}
}