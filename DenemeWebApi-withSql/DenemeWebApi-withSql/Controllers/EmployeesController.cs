using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DenemeWebApi_withSql.DAL;

namespace DenemeWebApi_withSql.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
        [HttpGet]//Api içerisinde Custom method ismi vermek için gerekir.Örn get için bu şekildedir.
        public HttpResponseMessage LoadEmployeeById(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var entity = entities.Employees.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id= " + id.ToString() + "is not found");
                }
            }
        }
        public HttpResponseMessage Post([FromBody]Employee emp)
        {

            try
            {
                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, emp);
                    message.Headers.Location = new Uri(Request.RequestUri + emp.ID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    var entity = db.Employees.FirstOrDefault(x=>x.ID==id);
                    if (entity==null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Employee with Id= "+id.ToString()+"is not found to delete");
                    }
                    else
                    {
                        db.Employees.Remove(entity);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }

        }

        public HttpResponseMessage Put(int id,[FromBody]Employee emp)
        {
            try
            {
                using (EmployeeDBEntities db = new EmployeeDBEntities())
                {
                    var entity = db.Employees.FirstOrDefault(x => x.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id= " + id.ToString() + "is not found to update");
                    }
                    else
                    {
                        entity.FirstName = emp.FirstName;
                        entity.LastName = emp.LastName;
                        entity.Gender = emp.Gender;
                        entity.Salary = emp.Salary;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK,entity);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }



    }
}
