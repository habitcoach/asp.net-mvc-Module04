using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Module04.Filter
{
    public class LogActionFilter : ActionFilterAttribute
    {
       
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action method is executing.");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action method has executed.");
        }
    }

}
