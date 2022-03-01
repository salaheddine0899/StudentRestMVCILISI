using Microsoft.AspNetCore.Mvc;
using MvcApp.Model;
using System.Linq;

namespace MvcApp
{
    [Route("api/students")]
    public class StudentsRestService:Controller
    {
        private MyDbContext dbService;

       
        public StudentsRestService(MyDbContext dbContext)
        {
            dbService = dbContext;
        }

        [HttpGet]
        public IEnumerable<Student> list()
        {
            return dbService.Students;
        }

        [HttpGet("{Id}")]
        public Student DetOne(long Id)
        {
            return dbService.Students.FirstOrDefault(s => s.Id == Id);
        }

        [HttpPost]
        public Student Save([FromBody]Student student)
        {
            dbService.Students.Add(student);
            dbService.SaveChanges();
            return student;
        }
        [HttpDelete("{Id}")]
        public void Delete(long Id)
        {
            Student student = dbService.Students.FirstOrDefault(s => s.Id == Id);
            dbService.Students.Remove(student);
            dbService.SaveChanges();
        }

        [HttpPut("{Id}")]
        public Student Update(long Id,[FromBody]Student student)
        {
            student.Id = Id;
            dbService.Students.Update(student);
            dbService.SaveChanges();
            return student;
        }
    }
}
