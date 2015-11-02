using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HelloWorld.BLL;

namespace HelloWorld.Controllers
{
    public class PublicController : ApiController
    {

        public string GetMessage()
        {
            //Accessed through: http://localhost:64333/api/public/getmessage
            var result = string.Empty;

            try
            {
                var mainMessages = new BLL.MainMessages();
                result = mainMessages.GetMessage(Messages.RequestSource.API);

            }
            catch (Exception ex)
            {
                var message = $"There was an unexpected error. Please contact the suport team. Error: {ex.Message}";
                Debug.WriteLine(message);
                result = message;
            }

            return result;
        }
    }
}
