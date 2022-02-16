namespace Exercise14.Page
{
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;

    namespace PageObject.BaseEntities
    {
        public abstract class BasePage
        {
            protected IWebDriver Driver;
            private int loadTime = 10;

            public BasePage(IWebDriver driver, bool urlOpen)
            {
                Driver = driver;

                if (urlOpen)
                {
                    OpenPage();
                }

                WaitForOpen();
            }

            protected abstract void OpenPage();
            public abstract bool IsPageOpened();

            protected void WaitForOpen()
            {
                var sec = 0;
                var indicatorOpenedPage = IsPageOpened();
                while (! indicatorOpenedPage && sec < loadTime)
                {
                    Thread.Sleep(2000);
                    sec++;
                    indicatorOpenedPage = IsPageOpened();
                }

                if (!indicatorOpenedPage)
                {
                    throw new AssertionException("Page was not opened.");
                }
            }
        }
    }
}