using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookMeInAllInOne.Web.Models;

namespace BookMeInAllInOne.Web.Controllers
{
    public class SiteAPIController : ApiController
    {

        private BookMeInContext db = new BookMeInContext();
        // GET api/site
        public IEnumerable<Site> Get()
        {
            return db.Sites.AsEnumerable();
        }

        // GET api/site/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/site
        public HttpResponseMessage Post(Site siteInfo)
        {
            if (ModelState.IsValid)
            {
                db.Sites.Add(siteInfo);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, siteInfo);
                return response;

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // PUT api/site/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/site/5
        public void Delete(int id)
        {
        }
    }
}
