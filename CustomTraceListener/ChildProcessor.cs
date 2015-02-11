using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTraceListener
{
    public class ChildProcessor
    {
        public void DoChildProcessing()
        {
            for(Int32 i = 0; i < 10; i++)
            {
                Trace.WriteLine(String.Format("Child is processing: {0}", DateTime.UtcNow));
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }
    }
}
