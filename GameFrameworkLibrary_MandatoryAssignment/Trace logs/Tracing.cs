using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameworkLibrary_MandatoryAssignment.Trace_logs
{
    public class Tracing
    {
        public static TraceSource ts = new TraceSource(("My Game Application"));

        static Tracing()
        {
            ts.Switch = new SourceSwitch("MyLogs", "All");
            string logFile = "FileLog.txt";

            TraceListener traceListener = new TextWriterTraceListener(new StreamWriter(logFile));

            traceListener.Filter = new EventTypeFilter(SourceLevels.All);

            ts.Listeners.Add(traceListener);
        }


        /// <summary>
        /// This is a method that writes the logs
        /// </summary>
        /// <param name="traceEventType">It traces the event type</param>
        /// <param name="message">and the message</param>
        public static void log(TraceEventType traceEventType, string message)
        {
            ts.TraceEvent(traceEventType, 111, message);
            ts.Close();
        }

    }
}
