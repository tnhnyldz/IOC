using System;

namespace IOC.Web.Models
{
    public interface IDateService
    {
        DateTime GetDayTime { get; }
    }
    public interface ISingletonDateService:IDateService
    {
      
    }
    public interface IScopedDateService : IDateService
    {

    }
    public interface ITransientDateService : IDateService
    {

    }
}
