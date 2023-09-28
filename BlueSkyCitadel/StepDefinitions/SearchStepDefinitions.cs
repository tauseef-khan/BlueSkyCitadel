using BlueSkyCitadel.Hooks;
using BlueSkyCitadel.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        SearchPage _searchPage = new SearchPage();

        [Given(@"I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click on the search field")]
        public void WhenIClickOnTheSearchField()
        {
            _searchPage.ClickSearchField();
        }

        [When(@"I type '(.*)' in the search field")]
        public void WhenITypeInTheSearchField(string searchText)
        {
            _searchPage.TypeInSearchField(searchText);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _searchPage.ClickSearchButton();
        }

        [Then(@"the result page is displayed")]
        public void ThenTheResultPageIsDisplayed()
        {
            _searchPage.IsSearchResultPageDisplayed().Should().BeTrue();
            driver.Close();
        }
    }
}
