using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.BLL
{
    public class MainMessages: Messages
    {
        private bool _logActivities;
        public MainMessages()
        {
            // Get config file setting to detemrine logging.
            _logActivities = ConfigurationManager.AppSettings["LogActivities"] == "true";
        }
        public override string GetMessage(RequestSource requestSource)
        {
            var result = string.Empty;
            switch (requestSource)
            {
                case RequestSource.Web:
                    result = "Hello World!";
                    break;
                case RequestSource.API:
                    result = "Hello World from API!";
                    break;
            }

            if (_logActivities)
            {
                LogMessage(requestSource);
            }

            return result;
        }
    }
}
