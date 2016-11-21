using OpenQA.Selenium;

namespace RowingAutomation
{
    public class TopNavigation
    {
        public class Contests
        {
            public class ContestsList
            {
                public static void Select()
                {
                    MenuSelector.Select("dropdownContest", "contest");
                }

            }
        }

        public class Trainings
        {
            public class TrainingsList
            {
                public static void Select()
                {
                    MenuSelector.Select("dropdownTraining", "trainings");                   
                }

            }
        }
    }

    public class MenuSelector
    {
        public static void Select(string topLevelMenuId, string subMenuId)
        {
            var topLevelMenu = Driver.Instance.FindElement(By.Id(topLevelMenuId));
            topLevelMenu.Click();

            var subMenu = Driver.Instance.FindElement(By.Id(subMenuId));
            subMenu.Click();
        }
    }

    //did i really need this one?
    public enum TopNavigationtype
    {
        ContestEnrollment
    }
}
