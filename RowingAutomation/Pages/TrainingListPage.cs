using System;
using RowingAutomation.Operations;
using OpenQA.Selenium;

namespace RowingAutomation
{
    public class TrainingListPage
    {
        public static void GoTo()
        {
            TopNavigation.Trainings.TrainingsList.Select();
        }

        public static FindAndOpenCommand FindAndOpenTraining(string trainingName)
        {
            return new FindAndOpenCommand(trainingName);
        }

        public static FindAndDeleteCommand FindAndDeleteTraining(string trainingName)
        {
            return new FindAndDeleteCommand(trainingName);
        }

        public static void SearchForTraining(string v)
        {
            var searchField = Driver.Instance.FindElement(By.Id("SearchString"));
            searchField.SendKeys(v);

            var searchButton = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/form/p/button"));
            searchButton.Click();
        }
    }

    public class FindAndDeleteCommand
    {
        private string date;
        private readonly string trainingName;

        public FindAndDeleteCommand(string trainingName)
        {
            this.trainingName = trainingName;
        }

        public FindAndDeleteCommand WithDate(string date)
        {
            this.date = date;
            return this;
        }

        public void Delete()
        {
            string dateFormatted = DateOps.DateToPolishFormatInString(date);
            string expectedString = trainingName + " " + dateFormatted;
            string xpathToRowPostion = "]/td[3]/a[3]";

            TableOps.FindAndOpenRowInTable(expectedString, xpathToRowPostion);

            var deleteButton = Driver.Instance.FindElement(By.XPath("//form/div/input"));
            deleteButton.Click();
        }
    }

    public class FindAndOpenCommand
    {
        private string date;
        private readonly string trainingName;

        public FindAndOpenCommand(string trainingName)
        {
            this.trainingName = trainingName;
        }

        public FindAndOpenCommand WithDate(string date)
        {
            this.date = date;
            return this;
        }

        public void Open()
        {
            string dateFormatted = DateOps.DateToPolishFormatInString(date);
            string expectedString = trainingName + " " + dateFormatted;
            string xpathToRowPostion = "]/td[3]/a[2]";

            TableOps.FindAndOpenRowInTable(expectedString, xpathToRowPostion);           
        }
    }
}
