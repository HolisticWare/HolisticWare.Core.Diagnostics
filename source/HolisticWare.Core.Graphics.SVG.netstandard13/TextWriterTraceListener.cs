namespace Core.Diagnostics
{
    /// <summary>
    /// 
    /// .NET Standard	2.0
    /// https://apisof.net/catalog/System.Diagnostics.TextWriterTraceListener
    /// </summary>
    public class ConsoleTraceListener
        :
        System.Diagnostics.TextWriterTraceListener
    {
        public ConsoleTraceListener()
            :
            base(System.Console.Out)
        {
            return;
        }

        public ConsoleTraceListener(System.IO.TextWriter tw)
            :
            base(tw)
        {
            return;
        }

        public ConsoleTraceListener(bool useErrorStream)
            :
            base(useErrorStream ? System.Console.Error : System.Console.Out)
        {
            return;
        }

    }
}