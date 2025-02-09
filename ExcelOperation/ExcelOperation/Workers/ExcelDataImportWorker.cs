using ClosedXML.Excel;
using ExcelOperation.Model;
using ExcelOperation.Repositories;

namespace ExcelOperation.Workers
{
    public class ExcelDataImportWorker
    {
        private readonly StudentRepo studentRepo;
        private readonly ILogger<ExcelDataImportWorker> logger;

        public ExcelDataImportWorker(StudentRepo studentRepo,
            ILogger<ExcelDataImportWorker>logger)
        {
            this.studentRepo = studentRepo;
            this.logger = logger;
        }

        public async Task DoWork(ExcelDataImportRequest request)
        {
            logger.LogInformation("Reading excel file for request {requestId}", request.RequestId);
            var students= ReadStudent(request);
            logger.LogInformation("Total members: {studentCount} from Request {requestId}",
                students.Count,
                request.RequestId);
            await studentRepo.Create(students);
            logger.LogInformation($"{request.RequestId} processed sucessfully.");
        }

        private List<Student> ReadStudent(ExcelDataImportRequest request)
        {
            List<Student> students = new List<Student>();
            using (var workbook=new XLWorkbook(request.FileData))
            {
                var worksheet = workbook.Worksheet(1);
                foreach(var row in worksheet.RowsUsed().Skip(request.HasHeader?1:0))
                {
                    students.Add(new Student
                    {
                        Id =Int32.Parse(row.Cell(1).GetString()),
                        Name=row.Cell(2).GetString(),
                    });
                }
            }
            return students;
        }
    }
}
