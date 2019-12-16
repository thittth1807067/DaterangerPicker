using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo1.Controllers
{
    public class DaterangePickerController : Controller
    {
        // GET: DaterangePicker
        public ActionResult Index( DateTime? start)
        {

            return View();
        }
    }
}