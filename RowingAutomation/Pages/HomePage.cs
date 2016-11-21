namespace RowingAutomation
{
    public class HomePage
    {
        public static bool IsAt
        {
            get
            {
                string url = Driver.BaseAddress;
                if (url == Driver.Instance.Url) return true;
                return false;
            }
        }
    }
}
