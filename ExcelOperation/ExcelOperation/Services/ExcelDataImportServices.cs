using System.Threading.Channels;
using ExcelOperation.Model;
using ExcelOperation.Workers;

namespace ExcelOperation.Services
{
    public class ExcelDataImportServices:BackgroundService
    {
        private readonly Channel<ExcelDataImportRequest> channel;
        private readonly ExcelDataImportWorker excelDataImportWorker;

        public ExcelDataImportServices(Channel<ExcelDataImportRequest>channel,
            ExcelDataImportWorker excelDataImportWorker)
        {
            this.channel = channel;
            this.excelDataImportWorker = excelDataImportWorker;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Run(async () =>
            {
                while (channel.Reader.CanPeek)
                {
                    var request=await channel.Reader.ReadAsync(stoppingToken);
                    await excelDataImportWorker.DoWork(request);
                }
            });
        }
    }
}
