using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace OdeToFood.Models.WebAPI
{
    public class CountryController : ApiController
    {
        // GET api/country
        [System.Web.Http.HttpGet]
        public JsonResult Get()
        {
            var retVal = JsonConvert.SerializeObject(LoadCountries());
            JsonResult json = new JsonResult()
            {
                Data = retVal
            };
            return json;
        }

        private List<string> LoadCountries()
        {
            List<string> list = new List<string>();

            list.Add("Serbia");
            list.Add("USA");
            list.Add("France");
            list.Add("Canada");

            return list;
        }

        // GET api/country/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/country
        public void Post([FromBody]string value)
        {
        }

        // PUT api/country/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/country/5
        public void Delete(int id)
        {
        }
    }
}
