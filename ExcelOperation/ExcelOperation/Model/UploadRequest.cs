namespace ExcelOperation.Model
{
    public class UploadRequest
    {
        public IFormFile? ImportFile { get; set; }
        public bool HasHeader { get; set; }
    }
}
