using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.BLL;


namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        #region Controller Calls
        public ActionResult Index()
        {
            try
            {
                var mainMessages = new BLL.MainMessages();
                ViewBag.Message = mainMessages.GetMessage(Messages.RequestSource.Web);

            }
            catch (Exception ex)
            {
                var message = $"There was an unexpected error. Please contact the suport team. Error: {ex.Message}";
                Debug.WriteLine(message);
                ViewBag.Message = message;
            }
            
            return View();
        }

        #endregion
    }
}