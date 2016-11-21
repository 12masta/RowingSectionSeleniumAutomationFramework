using OpenQA.Selenium;

namespace RowingAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "Account/Login");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("UserName"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("Password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.XPath("/html/body/div[2]/div/div/div/section/form/div/div[4]/div/input"));
            loginButton.Click();
        }
    }
}
