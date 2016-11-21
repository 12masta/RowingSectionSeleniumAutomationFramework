using OpenQA.Selenium;

namespace RowingAutomation
{
    public class TrainingDetailsPage
    {
        public static string TrainingName
        {
            get {
                var trainingName = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div[1]/dl/dd[1]"));
                if(trainingName != null)
                    return trainingName.Text;
                return "";
            }
        }

        public static string TrainingDate
        {
            get
            {
                var trainingDate = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div[1]/dl/dd[2]"));
                if (trainingDate != null)
                    return trainingDate.Text;
                return "";
            }
        }
      
    }
}
