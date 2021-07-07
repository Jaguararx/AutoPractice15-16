using AutoPractice15.Main;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoPractice15
{
    public class MainPage : PageObjectBase
    {
        public MainPage(IWebDriver driver) : base(driver) {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "treemenu")]
        //[CacheLookup]
        public IWebElement menuList;

        public MenuList MenuList
        {
            get { return new MenuList(menuList); }
        }
    }
}
