using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Text;

using TradingEngineServer.Core.Configuration;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineHostBuilder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((hostcontext, services)
                =>
                 {
                //start with configuration
                services.AddOptions();
                services.Configure<TradingEngineServerConfiguration>(hostcontext.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));

                //add singleton objects
                services.AddSingleton<ITradingEngine, TradingEngineServer>();
                services.AddSingleton<ITextLogger, TextLogger>();

                //add hosted service
                services.AddHostedService<TradingEngineServer>();
            }).Build();
    }
}


