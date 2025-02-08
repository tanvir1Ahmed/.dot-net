using Microsoft.AspNetCore.Mvc;
//using NPOI.HSSF.UserModel;
//using NPOI.SS.UserModel;

namespace ExcelOperation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        //[NonAction]
        //public static List<Dictionary<string, string>> ExcelFileReader(MemoryStream memoryStream, int headerRowNumber = 0, int dataRowNumber = 1, string fileName = "")
        //{
        //    var dataList = new List<Dictionary<string, string>>();
        //    try
        //    {
        //        var headNameOfFile = new List<string>();

        //        var Report_File = new FormFile(memoryStream, 0, memoryStream.Length, "file", fileName)
        //        {
        //            Headers = new HeaderDictionary(),
        //            ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        //        };
        //        using (var stream = Report_File.OpenReadStream())
        //        {
        //            IWorkbook workbook;

        //            var extension = Path.GetExtension(Report_File.FileName).ToLowerInvariant();
        //            if (extension == ".xlsx")
        //            {
        //                workbook = new NPOI.XSSF.UserModel.XSSFWorkbook(stream);

        //            }
        //            else if (extension == ".xls")
        //            {
        //                workbook = new HSSFWorkbook(stream);
        //            }
        //            else
        //            {
        //                throw new("Invalid File Extension.");
        //            }
        //            var worksheet = workbook.GetSheetAt(0);

        //            var headerRow = worksheet.GetRow(headerRowNumber);
        //            for (int i = 0; i < headerRow.Count(); i++)
        //            {
        //                var headerName = headerRow.GetCell(i)?.ToString()?.Trim() ?? "";
        //                headNameOfFile.Add(headerName);
        //            }
        //            var rowCount = worksheet.LastRowNum;
        //            for (int rowIndex = dataRowNumber; rowIndex <= rowCount; rowIndex++)
        //            {
        //                var rowDictionary = new Dictionary<string, string>();
        //                var row = worksheet.GetRow(rowIndex);
        //                if (row == null) continue;
        //                for (int i = 0; i < headNameOfFile.Count; i++)
        //                {
        //                    rowDictionary.Add(headNameOfFile[i], row.GetCell(i)?.ToString()?.Trim() ?? "");
        //                }
        //                dataList.Add(rowDictionary);
        //            }
        //        }
        //        return dataList;
        //    }
        //    catch (Exception ex)
        //    {
        //        return dataList;
        //    }
        //}

        ////public async Task<ActionResult<UploadResponse>>Upload(UploadRequest request)
        ////{
        ////    if(request.ImportFile is  null)
        ////    {
        ////        return BadRequest("Invalid Import File");
        ////    }
        ////    var requestId=Guid.NewGuid().ToString();
        ////    var importRequest = new ExcelDataImportRequest(requestId);
        ////    importRequest.has
        ////}
        //[HttpPost]
        //public async Task<IActionResult> InsertFileETLAsync(IFormFile Report_File)
        //{
        //    try
        //    {
        //        using var memoryStream = await ConvertToMemoryStream(Report_File);
        //        // var insertModelList = new List<InsertETLModel>();
        //        var rowDictionaryList = new List<Dictionary<string, string>>();

        //        //rowDictionaryList = ExcelFileReader(memoryStream, 0, 1, "AccessLog_20250120.xlsx");
        //        rowDictionaryList= await Task.Run(() => ExcelFileReader(memoryStream, 0, 1, "AccessLog_20250120.xlsx"));

        //        return Ok();
        //    }

        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        //}
        //[NonAction]
        //public async Task<MemoryStream> ConvertToMemoryStream(IFormFile file)
        //{
        //    var memoryStream = new MemoryStream();
        //    await file.CopyToAsync(memoryStream);
        //    memoryStream.Position = 0; // Reset position to the beginning
        //    return memoryStream;
        //}
    }
}
