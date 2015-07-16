using SoEasy.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoEasy
{
    public static class DateTimeExtension
    {
        public static string When(this DateTime date)
        {
            TimeSpan _diff = DateTime.Now - date;
            switch (_diff.Days)
            {
                case -1:
                    return Resources.Tomorrow;
                case 0:
                    return Resources.Today;
                case 1:
                    return Resources.Yesterday;
                default:
                    return date.ToShortDateString();
            }
        }
    }
}
