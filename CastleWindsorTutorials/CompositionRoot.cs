using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorTutorials
{
    public class CompositionRoot : ICompositionRoot
    {
        readonly IConsoleWriter consoleWriter;

        public void LogMessage(string message)
        {
            consoleWriter.LogMessage(message);
        }

        public CompositionRoot(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
            consoleWriter.LogMessage("Hello from CompositionRoot Constructor!");
        }

    }
}
