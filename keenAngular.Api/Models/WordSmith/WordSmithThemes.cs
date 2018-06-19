using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace keenAngular.Api.Models.WordSmith
{
	public class WordSmithThemes
	{
		public int ID { get; set; }
		public string WordThemeName { get; set; }
		public string WordThemeDescription { get; set; }
		public string WordThemeDate { get; set; }
		public DateTime InputDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}