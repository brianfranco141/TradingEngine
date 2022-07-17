using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using TradingEngineServer.Core.Configuration;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Core
{
    class TradingEngineServer : BackgroundService, ITradingEngine
    {
        private readonly IOptions<TradingEngineServerConfiguration> _engineConfiguration;
        private readonly ITextLogger _logger;
        public TradingEngineServer(IOptions<TradingEngineServerConfiguration> engineConfiguration, 
            ITextLogger textLogger)
        {
            _engineConfiguration = engineConfiguration ?? throw new ArgumentNullException(nameof(engineConfiguration));
            _logger = textLogger ?? throw new ArgumentNullException(nameof(textLogger));
        }

        public Task RunAsync(CancellationToken token) => ExecuteAsync(token);
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"Started {nameof(TradingEngineServer)}");
            while (!stoppingToken.IsCancellationRequested) 
            { 

            }
            _logger.LogInformation($"Stopped {nameof(TradingEngineServer)}");
            return Task.CompletedTask;
        }

        Task ITradingEngine.Run(CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}


