using System.Threading.Channels;
using ExcelOperation.Model;
using ExcelOperation.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcelOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly Channel<ExcelDataImportRequest> channel;
        private readonly StudentRepo studentRepo;

        public MemberController(Channel<ExcelDataImportRequest>channel,
            StudentRepo studentRepo)

        {
            this.channel = channel;
            this.studentRepo = studentRepo;
        }
        [HttpPost]
        public async Task<ActionResult<UploadResponse>>Upload(UploadRequest uploadRequest)
        {
            if(uploadRequest.ImportFile is  null)
            {
                return BadRequest("Invalid import file");
            }
            var requestId=Guid.NewGuid().ToString();
            var importRequest = new ExcelDataImportRequest(requestId);
            importRequest.HasHeader = uploadRequest.HasHeader;
            await uploadRequest.ImportFile.CopyToAsync(importRequest.FileData);

            await channel.Writer.WriteAsync(importRequest);
            return new UploadResponse
            {
                RequestId = requestId,
                FileName=uploadRequest.ImportFile.FileName,
                FileSize=uploadRequest.ImportFile.Length,
            };
        }
    }
}
