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
using App;
using BL;
using Data;

namespace App.Controllers
{
    [RoutePrefix("api/drzava")]
    public class DrzavaController : BaseApiController<Drzava>
    {
        public DrzavaController()
        {
            this.Bl = new DrzavaBl();
        }

        [HttpGet]
        [Route("GetAllActive")]
        public IEnumerable<Drzava> GetAllActive()
        {
            return Bl.List(i => i.Active == true);
        }
    }
}