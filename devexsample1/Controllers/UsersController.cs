using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using devexsample1.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

namespace devexsample1.Controllers {
    public class UsersController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            // Load data and return it with paging, filtering, etc. using DevExtreme's DataSourceLoader
            var result = DataSourceLoader.Load(SampleData.UsersData, loadOptions);
            return Request.CreateResponse(result);
        }
    }
}