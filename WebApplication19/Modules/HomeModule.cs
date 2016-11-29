using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace WebApplication19.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/{name}"] = _ =>
            {
                return View["/Home",_.name];
            };
        }
    }
}