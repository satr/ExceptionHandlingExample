using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NullLogger: ILogger
    {
        public void AddSource(ILogSource logSource)
        {
        }

        public void WriteCritical(string description)
        {
        }

        public void WriteCritical(string description, Exception exception)
        {
        }

        public void WriteError(string description)
        {
        }

        public void WriteError(string description, Exception exception)
        {
        }

        public void WriteWarning(string description)
        {
        }

        public void WriteInfo(string description)
        {
        }
    }
}
