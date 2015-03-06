using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chork.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        //public String Index()
        //{
        //    return "Index has been called";
        //}
        

        // GET: Hello/Welcome
        public String Welcome()
        {
            return "Welcome has been called";
        }
    }
}