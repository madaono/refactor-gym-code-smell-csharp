using System;

namespace code_smell_recognise._08
{
    public class ConfigSetting
    {
        public void UpdateConfig(string config) {
            Application.Count++;
            Application.Config = config.Substring(0, 8);
            // update other config
        }

        public void UpdateSettings(string adminSetting) {
            Application.Count++;
            Application.Config = adminSetting.Substring(4, 8) + DateTime.UtcNow.Year;
            // update other setting
        }

        public void ClearSettings() {
            Application.Count = 0;
            Application.Config = "zh/cn/2020";;
            // set other settings
        }
    }
}