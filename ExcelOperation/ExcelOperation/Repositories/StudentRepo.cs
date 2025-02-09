using ExcelOperation.Interfaces;
using ExcelOperation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperation.Repositories
{
    public class StudentRepo:IStudent
    {
        private readonly StudentDbContext dbContext;

        public StudentRepo(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Student>> Create(List<Student> student)
        {
            //var list = new List<Student>();
            foreach(var s in student)
            {
                //list.Add(s);
                await dbContext.Students.AddAsync(s);
            }
            return student;
        }
    }
}
