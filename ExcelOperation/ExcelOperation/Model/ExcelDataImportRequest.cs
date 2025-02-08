namespace ExcelOperation.Model
{
    public class ExcelDataImportRequest
    {
        public string? RequestId { get; set; }
        public MemoryStream FileData { get; set; }
        public bool HasHeader { get; set; }

        public ExcelDataImportRequest(string requestId)
        {
            RequestId= requestId;
            FileData= new MemoryStream();
        }
    }
}
