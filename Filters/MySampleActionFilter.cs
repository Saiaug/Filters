﻿using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Filters
{
    public class MySampleActionFilterAttribute : Attribute,  IActionFilter
    {
        private readonly string _name;

        public MySampleActionFilterAttribute(string name)
        {
            _name = name;
        }



        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionexecuting - {_name}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionexecuted - {_name}");
        }
    }
}
