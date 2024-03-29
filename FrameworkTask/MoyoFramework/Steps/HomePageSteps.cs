﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.PageActions;
using MoyoFramework.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MoyoFramework.Steps
{
    [Binding]
    public class HomePageSteps
    {

        [Given(@"I am on the '(.*)' page")]
        public void GivenIAmOnThePage(string pageName)
        {
            HomePageActions page = new HomePageActions();
            page.GetPage();
        }


        [Given(@"I perform search of the '(.*)' product")]
        [When(@"I perform search of the '(.*)' product")]
        public void WhenIPerformSearchOfTheProduct(string searchCriteria)
        {
            HomePageActions page = new HomePageActions();
            page.PerformSearch(searchCriteria);
        }

        [Given(@"I select '(.*)' category")]
        public void GivenISelectCategory(string categoryName)
        {
            HomePageActions page = new HomePageActions();
            page.SelectCategory(categoryName);
        }



    }
}
