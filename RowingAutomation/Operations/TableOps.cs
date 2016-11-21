using OpenQA.Selenium;
using System;

namespace RowingAutomation.Operations
{
    public class TableOps
    {
        public static void FindAndOpenRowInTable(string expectedString, string xpathToRowPosition)
        {
            int count = 1;
            int pagesCountInInt = 1;
            int pagesCountInIntOnPagination = 2;
            bool isFinded = false;
            var pagedListSkipToLast = Driver.Instance.FindElements(By.XPath("//ul/li[13]/a"));
            if(pagedListSkipToLast.Count != 0)
            {
                string pagesCount = pagedListSkipToLast[0].GetAttribute("href").ToString();
                pagesCount = pagesCount.Substring(pagesCount.Length - 2);
                pagesCountInInt = int.Parse(pagesCount);
            }

            for (int i = 0; i < pagesCountInInt; i++)
            {
                if (isFinded == false)
                {
                    var tableEl = Driver.Instance.FindElements(By.XPath("//table/tbody/tr"));
                    count = 1;
                    foreach (var el in tableEl)
                    {
                        if (el.Text.Equals(expectedString))
                        {
                            isFinded = true;
                            string xpath = "//table/tbody/tr[" + count.ToString() + xpathToRowPosition.ToString();
                            var openRowButton = el.FindElement(By.XPath(xpath));
                            openRowButton.Click();
                            break;
                        }
                        count++;
                    }
                }

                if (isFinded == false)
                {
                    string cssSelector = "[href *= '?page=" + pagesCountInIntOnPagination.ToString() + "']";
                    var nextPageButton = Driver.Instance.FindElement(By.CssSelector(cssSelector));
                    nextPageButton.Click();
                }
                else
                {
                    break;
                }
                pagesCountInIntOnPagination++;
            }
        }

        public static void FindAndOpenDeleteRowInTable(string expectedString, string xpathToRowPostion2)
        {
            int count = 1;
            int pagesCountInInt = 1;
            int pagesCountInIntOnPagination = 2;
            bool isFinded = false;
            var pagedListSkipToLast = Driver.Instance.FindElements(By.XPath("//ul/li[13]/a"));
            if (pagedListSkipToLast.Count != 0)
            {
                string pagesCount = pagedListSkipToLast[0].GetAttribute("href").ToString();
                pagesCount = pagesCount.Substring(pagesCount.Length - 2);
                pagesCountInInt = int.Parse(pagesCount);
            }

            for (int i = 0; i < pagesCountInInt; i++)
            {
                if (isFinded == false)
                {
                    var tableEl = Driver.Instance.FindElements(By.XPath("//table/tbody/tr"));
                    count = 1;
                    foreach (var el in tableEl)
                    {
                        if (el.Text.Equals(expectedString))
                        {
                            isFinded = true;
                            string xpath = "//table/tbody/tr[" + count.ToString() + xpathToRowPostion2.ToString();
                            var openRowButton = el.FindElement(By.XPath(xpath));
                            openRowButton.Click();
                            break;
                        }
                        count++;
                    }
                }

                if (isFinded == false)
                {
                    string cssSelector = "[href *= '?page=" + pagesCountInIntOnPagination.ToString() + "']";
                    var nextPageButton = Driver.Instance.FindElement(By.CssSelector(cssSelector));
                    nextPageButton.Click();
                }
                else
                {
                    break;
                }
                pagesCountInIntOnPagination++;
            }
        }
    }
}
