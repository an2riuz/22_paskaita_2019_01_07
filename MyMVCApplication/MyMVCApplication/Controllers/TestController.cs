using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Hello()
        {
            return "Hello world!";
        }
    }
}