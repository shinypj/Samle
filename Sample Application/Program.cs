using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{

    class Program
    {
        static void Main(string[] args)
        {
            // Open chrome browser  
            IWebDriver driver = new Chromedriver(@"C:\Users\SONY\Downloads\chromedriver_win32");

            //Go to the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
        }
    }
}
