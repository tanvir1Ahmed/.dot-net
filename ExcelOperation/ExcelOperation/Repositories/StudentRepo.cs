using ExcelOperation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperation.Repositories
{
    public class StudentRepo:DbContext
    {
        private readonly StudentDbContext dbContext;

        public StudentRepo(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Student>> Create(List<Student> student)
        {
            foreach(var studentItem in student)
            {
                await dbContext.Students.AddAsync(studentItem);
            }
            return student;
        }
    }
}
