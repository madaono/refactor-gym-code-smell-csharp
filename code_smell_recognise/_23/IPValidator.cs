using System.Text.RegularExpressions;

namespace code_smell_recognise._23
{
    public class IPValidator
    {
        public bool IsValidIp(string ipAddress) {
            if (string.IsNullOrEmpty(ipAddress)) {
                return false;
            }
            var regex = "^(1\\d{2}|2[0-4]\\d|25[0-5]|[1-9]\\d|[1-9])\\."
                        + "(1\\d{2}|2[0-4]\\d|25[0-5]|[1-9]\\d|\\d)\\."
                        + "(1\\d{2}|2[0-4]\\d|25[0-5]|[1-9]\\d|\\d)\\."
                        + "(1\\d{2}|2[0-4]\\d|25[0-5]|[1-9]\\d|\\d)$";
            return Regex.IsMatch(ipAddress, regex);
        }
    }
}