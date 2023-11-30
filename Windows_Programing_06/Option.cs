using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Programing_06
{
    internal class Option
    {
        private DriverOptions initbrowser()
        {
            var option = new ChromeOptions();
            option.AddArgument("headless");
            return option;
        }
    }
}
