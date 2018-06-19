using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace keenAngular.Api.Models.WordSmith
{
	public class WordSmithWords
	{
		public int ID { get; set; }
		public int WordSmithThemeID { get; set; }
		public string DailyWord { get; set; }
		public string Pronunciation { get; set; }
		public string Meaning { get; set; }
		public string Etymology { get; set; }
		public string Usage { get; set; }
		public string ThoughtADay { get; set; }
		public string Notes { get; set; }
		public DateTime InputDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}