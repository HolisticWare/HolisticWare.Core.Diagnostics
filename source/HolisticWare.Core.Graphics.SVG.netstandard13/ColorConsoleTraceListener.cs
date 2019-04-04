using System.Collections.Generic;
using System.Diagnostics;

namespace Core.Diagnostics
{
    /// <summary>
    /// 
    /// .NET Standard	2.0
    /// https://apisof.net/catalog/System.Diagnostics.TextWriterTraceListener
    /// </summary>
    public class ColorConsoleTraceListener
        :
        Core.Diagnostics.ConsoleTraceListener
    {
        public ColorConsoleTraceListener()
            :
            base(System.Console.Out)
        {
            return;
        }

        public ColorConsoleTraceListener(bool useErrorStream)
            :
            base(useErrorStream ? System.Console.Error : System.Console.Out)
        {
            return;
        }

        IEnumerable<(TraceEventType event, ConsoleColor color)> EventColors = null;

    }
}