using System;
using System.Diagnostics;
using System.Web.Mvc;
using XConnectClientWebApp.Models;

namespace XConnectClientWebApp.App_Start
{
    public class Startup : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Debug.WriteLine("A: Application_Start()");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("B: Application_Start(object sender, EventArgs e)");
        }

        protected void Application_OnStart()
        {
            Debug.WriteLine("C: Application_OnStart()");

        }
        protected void Application_OnStart(object sender, EventArgs e)
        {
            Debug.WriteLine("D: Application_OnStart(object sender, EventArgs e)");
        }
    }
}