using System;
using System.Linq;

namespace code_smell_recognise._23
{
    public class IPChecker
    {
        public bool CheckIp(string ipAddress) {
            if (string.IsNullOrEmpty(ipAddress)) {
                return false;
            }
            var ipUnits = ipAddress.Split(".").ToList();
            if (ipUnits.Count != 4) {
                return false;
            }
            for (var i = 0; i < 4; ++i) {
                int ipUnitIntValue;
                try {
                    ipUnitIntValue = Convert.ToInt32(ipUnits[i]);
                } catch (FormatException e) {
                    return false;
                }
                if (ipUnitIntValue < 0 || ipUnitIntValue > 255) {
                    return false;
                }
                if (i == 0 && ipUnitIntValue == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}