using System;

namespace code_smell_recognise._08
{
    public static class DateTimeUtils
    {
        public static string ToString(this DateTime localDateTime) {
            return ToLocalCulture(localDateTime, Application.Config);
        }

        private static string ToLocalCulture(DateTime localDateTime, string config) {
            // to make it simple, we just use the string to instead the handling from config and local date time.
            return "correctFormatByConfig";
        }
    }
}