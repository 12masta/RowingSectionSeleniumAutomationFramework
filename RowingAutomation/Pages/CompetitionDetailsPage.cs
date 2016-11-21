using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowingAutomation
{
    public class CompetitionDetailsPage
    {
        public static string CompetitionName
        {
            get
            {
                var competitionName = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div[1]/dl/dd[1]"));
                if (competitionName != null)
                    return competitionName.Text;
                return "";
            }
        }

        public static string CompetitionDate
        {
            get
            {
                var competitionDate = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div[1]/dl/dd[2]"));
                if (competitionDate != null)
                    return competitionDate.Text;
                return "";
            }
        }

        public static string CompetitionDescription
        {
            get
            {
                var competitionDescription = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div[1]/dl/dd[3]"));
                if (competitionDescription != null)
                    return competitionDescription.Text;
                return "";
            }
        }
    }
}
