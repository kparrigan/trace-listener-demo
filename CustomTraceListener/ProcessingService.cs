using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTraceListener
{
    public class ProcessingService
    {
        #region Constructor
        public ProcessingService()
        {
        
#if !DEBUG
            // Can also be configured in .config file
            Trace.Listeners.Add(new CustomTraceListener(@"C:\Trace.log"));
#else
            Trace.Listeners.Add(new ConsoleTraceListener());
#endif
        }
        #endregion

        #region Public 
        public void DoProcessing()
        {
            Trace.WriteLine(String.Format("Parent Do Processing Called: {0}", DateTime.UtcNow));

            var child = new ChildProcessor();
            child.DoChildProcessing();
        }
        #endregion
    }
}
