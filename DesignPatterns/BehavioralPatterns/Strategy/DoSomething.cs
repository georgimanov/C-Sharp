using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class DoSomething
    {
        private readonly ILogger logger;

        public DoSomething(ILogger logger)
        {
            this.logger = logger;
        }
        internal void Work()
        {
            this.logger.Log("Starting work...");
            this.logger.Log("Working...");
            this.logger.Log("Work done.");
        }
    }
}
