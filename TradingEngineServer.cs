using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

using System.Threading;
using System.Threading.Tasks;

namespace TradingEngineServer.core
{
    class TradingEngineServer : BackgroundService, ITradingEngineServer
    {
        private readonly ILogger<TradingEngineServer> _logger;
        public TradingEngineServer(ILogger<TradingEngineServer> logger, IOptions<>)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested) 
            { 

            }
        }
    }
}


