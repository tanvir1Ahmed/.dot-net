using ExcelOperation.Model;
using System.Runtime.InteropServices;

namespace ExcelOperation.Interfaces
{
    public interface IStudent
    {
        public Task<List<Student>> Create(List<Student> student);
    }
}
