using Microsoft.Extensions.Logging;
using System;

namespace IOC.Web.Models
{
    public class DateService : IScopedDateService, ITransientDateService, ISingletonDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            //default
            _logger = logger;
            _logger.LogWarning("ctor calıstı");
        }
        public DateTime GetDayTime { get; }=DateTime.Now;   
    }
}
