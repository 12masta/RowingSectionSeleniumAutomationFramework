using OpenQA.Selenium;
using RowingAutomation.Operations;
using System;
using System.Globalization;

namespace RowingAutomation
{
    public class CompetitionListPage
    {
        public static void GoTo()
        {
            TopNavigation.Contests.ContestsList.Select();
        }

        public static FindAndOpenCompetitionCommand FindAndOpenCompetition(string competitionName)
        {
            return new FindAndOpenCompetitionCommand(competitionName);
        }
        

        public static FindAndDeleteCompetitionCommand FindAndDeleteCompetition(string competitionName)
        {
            return new FindAndDeleteCompetitionCommand(competitionName);
        }
    }

    public class FindAndDeleteCompetitionCommand
    {
        private readonly string competitionName;
        private string competitionDate;
        private string competitionDescription;

        public FindAndDeleteCompetitionCommand(string competitionName)
        {
            this.competitionName = competitionName;
        }

        public FindAndDeleteCompetitionCommand WithDate(string competitionDate)
        {
            this.competitionDate = competitionDate;
            return this;
        }

        public FindAndDeleteCompetitionCommand WithDescription(string competitionDescription)
        {
            this.competitionDescription = competitionDescription;
            return this;
        }

        public void Delete()
        {
            string dateFormatted = DateOps.DateToPolishFormatInString(competitionDate);
            string expectedString = competitionName + " " + dateFormatted + " " + competitionDescription;
            string xpathToRowPostion = "]/td[4]/a[3]";

            TableOps.FindAndOpenRowInTable(expectedString, xpathToRowPostion);
            var deleteButton = Driver.Instance.FindElement(By.XPath("//form/div/input"));
            deleteButton.Click();
        }
    }

    public class FindAndOpenCompetitionCommand
    {
        private readonly string competitionName;
        private string competitionDate;
        private string competitionDescription;

        public FindAndOpenCompetitionCommand(string competitionName)
        {
            this.competitionName = competitionName;
        }

        public FindAndOpenCompetitionCommand WithDate(string competitionDate)
        {
            this.competitionDate = competitionDate;
            return this;
        }

        public FindAndOpenCompetitionCommand WithDescription(string competitionDescription)
        {
            this.competitionDescription = competitionDescription;
            return this;
        }

        public void Open()
        {
            string dateFormatted = DateOps.DateToPolishFormatInString(competitionDate);
            string expectedString= competitionName + " " + dateFormatted + " " + competitionDescription;
            string xpathToRowPostion = "]/td[4]/a[2]";

            TableOps.FindAndOpenRowInTable(expectedString, xpathToRowPostion);            
        }
    }
}

