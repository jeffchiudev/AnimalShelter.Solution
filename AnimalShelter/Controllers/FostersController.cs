using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FostersController : ControllerBase
    {
        private AnimalShelterContext _db;
        public FostersController(AnimalShelterContext db)
        {
            _db = db;
        }

        //GET api/fosters
        [HttpGet]
        public ActionResult<IEnumerable<Foster>> Get()
        {
            return _db.Fosters.ToList();
        }

        // POST api/fosters
        [HttpPost]
        public void Post([FromBody] Foster foster)
        {
            _db.Fosters.Add(foster);
            _db.SaveChanges();
        }

        // GET api/fosters/1
        [HttpGet("{id}")]
        public ActionResult<Foster> Get(int id)
        {
            return _db.Fosters.FirstOrDefault(entry => entry.FosterId == id);
        }

        // PUT api/fosters/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Foster foster)
        {
            foster.FosterId = id;
            _db.Entry(foster).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/fosters/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var fosterToDelete = _db.Fosters.FirstOrDefault(entry => entry.FosterId == id);
            _db.Fosters.Remove(fosterToDelete);
            _db.SaveChanges();
        }
    }
}