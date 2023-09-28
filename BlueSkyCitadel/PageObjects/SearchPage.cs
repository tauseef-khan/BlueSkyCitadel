using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;

namespace BlueSkyCitadel.PageObjects
{
    public class SearchPage
    {
        public IWebDriver driver;

        private By searchField = By.Id("search-courses-input");
        private By searchButton = By.ClassName("stm_lms_courses_search__button");
        
        public SearchPage() {

            driver = WebHook.driver;
        }

        public void ClickSearchField()
        {
            driver.FindElement(searchField).Click();
        }

        public void TypeInSearchField(string searchText)
        {
            driver.FindElement(searchField).SendKeys(searchText);
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public bool IsSearchResultPageDisplayed()
        {
            return driver.Url == @"https://prepmajor.com/courses/?search=automation";
        }
    }
}
