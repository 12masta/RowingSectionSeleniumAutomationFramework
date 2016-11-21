using OpenQA.Selenium;

namespace RowingAutomation
{
    public class NewTrainingPage
    {
        public static void GoTo()
        {
            var addTrainingButton = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
            addTrainingButton.Click();
        }

        public static CreateTrainingCommand CreateTraining(string trainingName)
        {
            return new CreateTrainingCommand(trainingName);
        }
    }

    public class CreateTrainingCommand
    {
        private readonly string trainingName;
        private string trainingDate;

        public CreateTrainingCommand(string trainingName)
        {
            this.trainingName = trainingName;
        }

        public CreateTrainingCommand WithDate(string date)
        {
            this.trainingDate = date;
            return this;
        }

        public void Publish()
        {
            var nameTrainingInput = Driver.Instance.FindElement(By.Id("Name"));
            nameTrainingInput.SendKeys(trainingName);

            var dateTrainingInput = Driver.Instance.FindElement(By.Id("TrainingDate"));
            dateTrainingInput.SendKeys(trainingDate);

            var submitButton = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/form/div/div[3]/div/input"));
            submitButton.Click();
        }
    }
}
