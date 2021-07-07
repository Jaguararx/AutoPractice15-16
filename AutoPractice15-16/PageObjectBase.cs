
using OpenQA.Selenium;

namespace AutoPractice15
{
    public abstract class PageObjectBase
    {
        private IWebDriver _driver;

        public IWebDriver Driver { get; set; }

        protected PageObjectBase(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
