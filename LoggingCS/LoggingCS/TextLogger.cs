using System;

using Microsoft.Extensions.Options;

using TradingEngineServer.Logging.LoggingConfiguration;

namespace TradingEngineServer.Logging
{
    public class TextLogger : AbstractLogger, ITextLogger
    {
        //private
        private readonly LoggerConfiguration _loggingConfiguration;

        public TextLogger(IOptions<TextLoggerConfiguration>loggingConfiguration) : base()
        {
            _loggingConfiguration = loggingConfiguration.Value ?? throw new ArgumentNullException(nameof(loggingConfiguration));

        }

        protected override void Log(LogLevel logLevel, string module, string message)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

