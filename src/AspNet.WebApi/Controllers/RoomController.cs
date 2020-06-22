using AspNet.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using static AspNet.WebApi.Models.Room;

namespace AspNet.WebApi.Controllers
{
    public class RoomController : ApiController
    {
        // GET: api/Room
        public IEnumerable<Room> GetRooms()
        {
            return Rooms;
        }

        // GET: api/Room/5
        public IHttpActionResult GetRoom(int id)
        {
            try
            {
                return Ok(Rooms.Where(room => room.RoomId == id).Single());
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }

        // POST: api/Room
        public void PostRoom([FromBody]Room newRoom)
        {
            Rooms.Add(newRoom);
        }

        // PUT: api/Room/5
        public IHttpActionResult PutRoom(int id, [FromBody]Room value)
        {
            try
            {
                Rooms.Remove(Rooms.Where(room => room.RoomId == id).Single());
                Rooms.Add(value);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
        }

        // DELETE: api/Room/5
        public IHttpActionResult DeleteRoom(int id)
        {
            try
            {
                Rooms.Remove(Rooms.Where(room => room.RoomId == id).Single());
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
        }
    }
}
