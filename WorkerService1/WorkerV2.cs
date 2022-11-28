using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerService1
{
    public class WorkerV2 : BackgroundService
    {
        private readonly ILogger<WorkerV2> _logger;

        public WorkerV2(ILogger<WorkerV2> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        // TODO: I have to add anything else
    }
}
