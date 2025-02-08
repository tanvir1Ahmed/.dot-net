

using ExcelOperation.Repositories;

namespace ExcelOperation.BackgroundServices
{
    public class SimpleService1 : IHostedService,IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private Timer? _timer;
        private readonly StudentRepo _data;

        public SimpleService1(StudentRepo data)
        {
            this._data = data;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
