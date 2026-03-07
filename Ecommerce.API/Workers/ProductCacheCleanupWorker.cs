using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Ecommerce.API.Workers;

public class ProductCacheCleanupWorker : BackgroundService
{
    private readonly ILogger<ProductCacheCleanupWorker> _logger;

    public ProductCacheCleanupWorker(ILogger<ProductCacheCleanupWorker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Background Worker running at: {time}", DateTimeOffset.Now);

            // Simulate background job
            await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
        }
    }
}