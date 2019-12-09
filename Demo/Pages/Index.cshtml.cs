using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.Pages
{
    public class IndexModel : PageModel
    {

        public static string GetNodeName()
        {
            string localString;
            if (Environment.GetEnvironmentVariable("NodeName") != null && Environment.GetEnvironmentVariable("NodeName").Length > 0)
            {
                localString = Environment.GetEnvironmentVariable("NodeName").ToString();
            }
            else
            {
                localString = "NotAvailable";
            }

            return localString;
        }

        public static string GetPodName()
        {
            string localString;
            if (Environment.GetEnvironmentVariable("PodName") != null && Environment.GetEnvironmentVariable("PodName").Length > 0)
            {
                localString = Environment.GetEnvironmentVariable("PodName").ToString();
            }
            else
            {
                localString = "NotAvailable";
            }

            return localString;
        }
        public void OnGet()
        {
            ViewData["node"] = GetNodeName();
            ViewData["pod"] = GetPodName();
        }
    }
}
