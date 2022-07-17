using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Text;

using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                //start with configuration
                services.AddOptions();
                services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));

                //add singleton objects
                services.AddSingleton<ITradingEngineServer, TradingEngineServer>();

                //add hosted service
                services.AddHostedService<TradingEngineServer>();
            }).Build();
    }
}


