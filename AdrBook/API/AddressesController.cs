using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.Description;
using AdrBook.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AdrBook.API
{
    public class AddressesController : ApiController
    {
        private AddressContext db = new AddressContext();

        // GET: api/Addresses
        public IEnumerable<Address> GetAddresses()
        {
            return db.Addresses.ToArray();
        }

        //GET: api/Addresses/5
        [ResponseType(typeof(Address))]
        public IHttpActionResult GetAddress(int Id)
        {
            Address address = db.Addresses.Find(Id);
            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AddressExists(int id)
        {
            return db.Addresses.Count(e => e.Id == id) > 0;
        }
    }
}