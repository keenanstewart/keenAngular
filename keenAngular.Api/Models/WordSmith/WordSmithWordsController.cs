using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using keenAngular.Api.Models;

namespace keenAngular.Api.Models.WordSmith
{
    public class WordSmithWordsController : ApiController
    {
        private keenAngularApiContext db = new keenAngularApiContext();

        // GET: api/WordSmithWords
        public IQueryable<WordSmithWords> GetWordSmithWords()
        {
            return db.WordSmithWords;
        }

        // GET: api/WordSmithWords/5
        [ResponseType(typeof(WordSmithWords))]
        public IHttpActionResult GetWordSmithWords(int id)
        {
            WordSmithWords wordSmithWords = db.WordSmithWords.Find(id);
            if (wordSmithWords == null)
            {
                return NotFound();
            }

            return Ok(wordSmithWords);
        }

        // PUT: api/WordSmithWords/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWordSmithWords(int id, WordSmithWords wordSmithWords)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wordSmithWords.ID)
            {
                return BadRequest();
            }

            db.Entry(wordSmithWords).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WordSmithWordsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/WordSmithWords
        [ResponseType(typeof(WordSmithWords))]
        public IHttpActionResult PostWordSmithWords(WordSmithWords wordSmithWords)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WordSmithWords.Add(wordSmithWords);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wordSmithWords.ID }, wordSmithWords);
        }

        // DELETE: api/WordSmithWords/5
        [ResponseType(typeof(WordSmithWords))]
        public IHttpActionResult DeleteWordSmithWords(int id)
        {
            WordSmithWords wordSmithWords = db.WordSmithWords.Find(id);
            if (wordSmithWords == null)
            {
                return NotFound();
            }

            db.WordSmithWords.Remove(wordSmithWords);
            db.SaveChanges();

            return Ok(wordSmithWords);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WordSmithWordsExists(int id)
        {
            return db.WordSmithWords.Count(e => e.ID == id) > 0;
        }
    }
}