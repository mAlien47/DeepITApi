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
    [RoutePrefix("api/grad")]
    public class GradController : BaseApiController<Grad>
    {
        public GradController()
        {
            this.Bl = new GradBl();
        }

        [HttpGet]
        [Route("getByDrzavaId/{id}")]
        public IEnumerable<Grad> GetByDrzavaID(int id)
        {
            return Bl.List(i => i.DrzavaID == id);
        }

        [HttpGet]
        [Route("GetAllActive")]
        public IEnumerable<Grad> GetAllActive()
        {
            return Bl.List(i => i.Active == true);
        }
    }
}