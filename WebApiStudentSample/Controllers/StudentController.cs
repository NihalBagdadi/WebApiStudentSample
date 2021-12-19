using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiStudentSample.Models;



namespace WebApiStudentSample.Controllers
{
    [EnableCors(origins: "http://localhost:5500,", headers: "Origin, Content-Type, X-Auth-Token", methods: "GET,POST,PUT,DELETE,OPTIONS,PATCH", SupportsCredentials = true)]
    public class StudentController : ApiController
    {
        IList<Students> students = new List<Students>()
        {
            new Students()
            {
                StudentId=1,
                StudentName="Nihal",
                Address="Mumbai",
                Course="IT"

            },
             new Students()
            {
                StudentId=2,
                StudentName="Niha",
                Address="Chiplun",
                Course="Cs"

            },
             new Students()
            {
                StudentId=3,
                StudentName="Nagma",
                Address="Khed",
                Course="Commerce"

            },
             new Students()
            {
                StudentId=4,
                StudentName="Naziya",
                Address="Pune",
                Course="Arts"

            },
        };
        public IList<Students> GetAllStudents()
        {
            return students;
        }
        public Students GetStudentDetails(int id)
        {
            var Student = students.FirstOrDefault(e => e.StudentId == id);
            if (Student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Student;
        }
    }
}
