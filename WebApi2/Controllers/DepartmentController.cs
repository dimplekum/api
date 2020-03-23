using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApi2.Controllers
{
    public class DepartmentController : ApiController
    {
        employeeEntities Db = new employeeEntities();



        public IEnumerable<DEPARTMENT> GetAll()
        {


            return Db.DEPARTMENTs.ToList();
        }

        [HttpGet]
        public DEPARTMENT Detail(int id)
        {
            DEPARTMENT dEPARTMENT = Db.DEPARTMENTs.Find(id);

            return dEPARTMENT;
        }

        [HttpPost]
        public IHttpActionResult Post(DEPARTMENT student)
        {
        

            Db.DEPARTMENTs.Add(student);

            Db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(DEPARTMENT student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");


            var existingStudent = Db.DEPARTMENTs.Where(s => s.ID == student.ID).FirstOrDefault<DEPARTMENT>();
            if (existingStudent != null)
            {
                existingStudent.NAME = student.NAME;
                Db.SaveChanges();

            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid studet id");

            DEPARTMENT D = Db.DEPARTMENTs.Find(id);

            Db.DEPARTMENTs.Remove(D);

            Db.SaveChanges();

            return Ok();
        }



    }
}
