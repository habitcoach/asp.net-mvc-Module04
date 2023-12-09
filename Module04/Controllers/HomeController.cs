using Microsoft.AspNetCore.Mvc;
using Module04.Filter;
using Module04.Models;
using System.Diagnostics;

namespace Module04.Controllers
{
    
    //[Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

          [Route("Index")]
        [LogActionFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        #region Config by convention

        /*
         configuraion by convention:  The porgram is designed in such a way the with minimu config it can perform something.
        SO even if you make a minor error there is a good change that you will fall into the pit of success
        For example in the below method Test, even if you search for Home/test it will still work ignoring the case
         */

        #endregion

        [Route("{Home}/{Test}/{id}")]
        public string Test(int id)
        {

            return $"This id  value is:{id}";
        }

        public string Test(int id, string val)
        {

            return $"This id  value is:{id} and {val}";
        }



        #region Parameter
        /*
        
        using parameter: Here is we send the value in the url like Test01?num=5&val=10 then it will be caputred here
        Also you can use HttpContext.Request.Query to read the data

         */

        #endregion
        public string Test01(int num, string val)
        {
            var val2 = HttpContext.Request.Query["val"];
            return $"The number is: {num} and the string value is {val} and number01 is {val2.ToString()}";
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}