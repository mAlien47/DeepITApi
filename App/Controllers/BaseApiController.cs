using BL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace App.Controllers
{
    public class BaseApiController<T> : ApiController where T : class, IEntity
    {
        protected BllBase<T> Bl;

        public virtual IEnumerable<T> Get()
        {
            return Bl.List();
        }

        public virtual IHttpActionResult Get(int id)
        {
            T entity = Bl.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        public virtual IHttpActionResult Put(T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            this.Bl.Update(entity);

            return StatusCode(HttpStatusCode.NoContent);
        }

        public virtual IHttpActionResult Post(T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            this.Bl.Insert(entity);

            return CreatedAtRoute("DefaultApi", new { id = entity.ID }, entity);
        }

        public virtual IHttpActionResult Delete(int id)
        {
            this.Bl.Delete(id);

            return Ok();
        }
    }
}
