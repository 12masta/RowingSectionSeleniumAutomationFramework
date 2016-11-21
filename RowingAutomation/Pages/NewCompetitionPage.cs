using OpenQA.Selenium;

namespace RowingAutomation
{
    public class NewCompetitionPage
    {
        public static void GoTo()
        {
            var menuTraining = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
            menuTraining.Click();
        }

        public static CreateCompetitionCommand CreateCompetition(string competitionName)
        {
            return new CreateCompetitionCommand(competitionName);
        }
    }

    public class CreateCompetitionCommand
    {
        private readonly string competitionName;
        private string competitionDate;
        private string competitionDescription;

        public CreateCompetitionCommand(string competitionName)
        {
            this.competitionName = competitionName;
        }

        public CreateCompetitionCommand WithDate(string date)
        {
            this.competitionDate = date;
            return this;
        }

        public CreateCompetitionCommand WithDescription(string description)
        {
            this.competitionDescription = description;
            return this;
        }

        public void Publish()
        {
            var nameCompetitionInput = Driver.Instance.FindElement(By.Id("Name"));
            nameCompetitionInput.SendKeys(competitionName);

            var dateCompetitionInput = Driver.Instance.FindElement(By.Id("ContestDate"));
            dateCompetitionInput.SendKeys(competitionDate);

            var descriptionCompetitionInput = Driver.Instance.FindElement(By.Id("Description"));
            descriptionCompetitionInput.SendKeys(competitionDescription);

            var submitButton = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/form/div/div[4]/div/input"));
            submitButton.Click();
        }
    }
}

