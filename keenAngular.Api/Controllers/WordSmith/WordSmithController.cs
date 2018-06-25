using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using keenAngular.Api.Models.WordSmith;
using Microsoft.AspNetCore.Cors;

namespace keenAngular.Api.Controllers.WordSmith
{
	public class WordSmithController : ApiController
	{
		IList<WordSmithThemes> wordSmithThemes = new List<WordSmithThemes>()
		{
			new WordSmithThemes()
			{
				ID = 1,
				WordThemeName = "Words borrowed from Sanskrit",
				WordThemeDescription = "Words borrowed from Sanskrit",
				WordThemeDate = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithThemes()
			{
				ID = 2,
				WordThemeName = "Words that appear rude, but aren't",
				WordThemeDescription = "Words that appear rude, but aren't",
				WordThemeDate = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithThemes()
			{
				ID = 3,
				WordThemeName = "Words borrowed from other languages",
				WordThemeDescription = "Words borrowed from other languages",
				WordThemeDate = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			}
		};

		IList<WordSmithWords> words = new List<WordSmithWords>()
		{
			new WordSmithWords()
			{
				ID = 1,
				WordSmithThemeID = 1,
				DailyWord = "brahmin",
				Pronunciation = "(BRAH-min)",
				Meaning = "noun: A member of the upper class, having wealth, social status, and political power.",
				Etymology = "From Sanskrit brahmin, a member of the priestly class, the highest of the four classes, from Brahma, the creator of the universe in Hinduism. Earliest documented use: 1481.",
				Usage = "\"The wealthiest, the Brahmins, are zoned off from everyone else, eating gold-leaf-sprinkled chocs, purchasing mansions and penthouses, hunting and shooting on vast estates, protecting their billions from impertinent tax collectors, buying political influence." +
						"Yasmin Alibhai-Brown; It's Time to Take Up the Cudgels Against Planned Poverty; The Independent (London, UK); Jun 22, 2015. " + 
						"Mrs. Guth, a philanthropist and a descendant of one of the founders of the pharmaceutical company Merck, was doing little to lighten the old-money mood. She spoke with a Brahmin accent to rival Katharine Hepburn's, and initially appeared wary of the slightest personal revelation. 'Why do we have to do that?' she said when asked to talk about her roots in New Hampshire.\" Steven Kurutz; Greening the Gilded Age; The New York Times; Aug 7, 2014.   ",
				ThoughtADay = "A poor idea well written is more likely to be accepted than a good idea poorly written. -Isaac Asimov, scientist and writer (2 Jan 1920-1992)",
				Notes = "http://wordsmith.org/words/brahmin.html",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithWords()
			{
				ID = 2,
				WordSmithThemeID = 1,
				DailyWord = "avatar",
				Pronunciation = "(AV-uh-tahr)",
				Meaning = "noun: 1. An embodiment of a concept. 2. A representation of a person or thing in computers, networks, etc.",
				Etymology = "From Sanskrit avatar (descent, as of a god from heaven to the earth), from ava- (away) + tarati (he crosses). Ultimately from the Indo-European root ter?- (to cross over or pass through, to overcome), which also gave us through, thorough, transient, nostril, and thrill. Earliest documented use: 1784. ",
				Usage = "\"The president is our national avatar -- a stand-in for what we believe we are, or want to be.\" Joy-Ann Reid; Surviving Trump's Reality Show; The Daily Beast (New York); Dec 17, 2016.   ",
				ThoughtADay = "It does not do to leave a live dragon out of your calculations, if you livenear him. -J.R.R. Tolkien, novelist and philologist (3 Jan 1892-1973)",
				Notes = "http://wordsmith.org/words/avatar.html",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithWords()
			{
				ID = 3,
				WordSmithThemeID = 1,
				DailyWord = "pundit or pandit",
				Pronunciation = "(PUN-dit)",
				Meaning = "",
				Etymology = "",
				Usage = "",
				ThoughtADay = "",
				Notes = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithWords()
			{
				ID = 4,
				WordSmithThemeID = 1,
				DailyWord = "swami",
				Pronunciation = "(SWAM-ee)",
				Meaning = "",
				Etymology = "",
				Usage = "",
				ThoughtADay = "",
				Notes = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},

			new WordSmithWords()
			{
				ID = 5,
				WordSmithThemeID = 1,
				DailyWord = "karma",
				Pronunciation = "(KAHR-ma)",
				Meaning = "",
				Etymology = "",
				Usage = "",
				ThoughtADay = "",
				Notes = "",
				InputDate = new DateTime(),
				UpdateDate = new DateTime(),
			},
		};

		[HttpGet]
		[EnableCors("*")]
		public IList<WordSmithWords> GetAllWords()
		{
			return words;
		}

		[HttpGet]
		public WordSmithWords GetWordDetails(int id = 1)
		{
			var word = words.FirstOrDefault(w => w.ID == id);
			if (word == null)
			{
				throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
			}

			return word;
		}
    }
}
