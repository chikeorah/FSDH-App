using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FSDH_App
{
    public interface IMyService
    {
        public void WriteLog(string message);
    }
    public class MyService : IMyService
    {
        public ILogger Logger { get; set; }
        public void WriteLog(string message)
        {
            Logger.LogInformation(message);
        }
    }
}
