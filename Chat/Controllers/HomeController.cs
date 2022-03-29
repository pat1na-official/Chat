using Chat_2._0.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_2._0.Controllers
{
    public class HomeController : Controller
    {
 


        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }


}
