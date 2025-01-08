using Assesment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assesment1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi"},
            new Country { ID = 2, CountryName = "Italy", Capital = "Rome" },
            new Country { ID = 3, CountryName = "France", Capital = "Paris" },
            new Country { ID = 4, CountryName = "UK", Capital = "London" }
           
        };

        // GET: api/country
        public IEnumerable<Country> GetCountries()
        {
            return countries;
        }

        // GET: api/country/1
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/country
        public IHttpActionResult PostCountry(Country country)
        {
            country.ID = countries.Max(c => c.ID) + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT: api/country/1
        public IHttpActionResult PutCountry(int id, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/country/1
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}
