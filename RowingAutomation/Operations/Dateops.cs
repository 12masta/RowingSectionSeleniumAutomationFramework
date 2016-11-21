using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowingAutomation.Operations
{
    public class DateOps
    {
        public static string DateToPolishFormatInString(string date)
        {
            DateTimeFormatInfo fmt = (new CultureInfo("pl-PL")).DateTimeFormat;
            DateTime dateFormatted = DateTime.Parse(date.ToString());
            return dateFormatted.ToString("yyyy-MM-dd", fmt);
        }
    }
}
