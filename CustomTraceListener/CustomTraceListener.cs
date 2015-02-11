using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTraceListener
{
    public class CustomTraceListener : TraceListener
    {
        #region Member Variables
        private readonly string _logPath;
        #endregion

        #region Constructor
        public CustomTraceListener(string logPath)
        {
            _logPath = logPath;
        }
        #endregion

        #region Overrides
        public override void Write(string message)
        {
            this.WriteLine(message);
        }

        public override void WriteLine(string message)
        {
            using (var file = new StreamWriter(_logPath, true))
            {
                file.WriteLine(message);
            }
        }
        #endregion

        #region IDisposable
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #endregion
    }
}
