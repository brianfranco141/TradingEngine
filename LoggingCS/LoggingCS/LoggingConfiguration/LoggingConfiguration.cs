using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging.LoggingConfiguration
{
    class LoggingConfiguration
    {
        public LoggerType loggerType { get; set; }
        public TextLoggerConfiguration TextLoggerConfiguration { get; set; }
    }

    class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string Filename { get; set; }    
        public string FileExtension { get; set; }

    }
}
