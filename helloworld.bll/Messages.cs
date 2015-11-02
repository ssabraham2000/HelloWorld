using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.BLL
{
    public abstract class Messages
    {
        public abstract string GetMessage(RequestSource requestSource);
        
        public void LogMessage(RequestSource requestSource)
        {
            //TODO: write to log table in the database
        }

        public enum RequestSource
        {
            Web,
            API
        }
    }
}
