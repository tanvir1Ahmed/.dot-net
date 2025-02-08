

using System.Threading;

namespace ExcelOperation.BackgroundServices
{
    public class SimpleService2:BackgroundService
    {
        private Timer? _timer;
        private readonly ILogger _logger;

        public SimpleService2(ILogger<SimpleService1> logger)
        {
            _logger = logger;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _timer = new Timer(_timer_Callback,
                null,
               TimeSpan.FromSeconds(1),
               TimeSpan.FromSeconds(1));
            return Task.CompletedTask;
        }

        private void _timer_Callback(object? state)
        {
            _logger.LogInformation("Timer Callback from Simple Service 2");
        }
    }
}
