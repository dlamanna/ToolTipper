using System.IO;
using System.Text.RegularExpressions;

namespace ToolTipper.Properties { 
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        public static System.Drawing.Color foregroundColor;
        public static System.Drawing.Color backgroundColor;
        public static System.Drawing.Point positionSave;

        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            this.SettingChanging += this.SettingChangingEventHandler;
            //
            this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }

        public static void scanSettings()
        {
            using (var sr = new StreamReader("..\\settings.ini"))
            {
                foregroundColor = System.Drawing.ColorTranslator.FromHtml(scanLine(sr));
                backgroundColor = System.Drawing.ColorTranslator.FromHtml(scanLine(sr));
                for (int i = 0; i < 8; i++)
                {
                    string trashLine = scanLine(sr);
                }
                var positionString = scanLine(sr);
                var g = Regex.Replace(positionString, @"[\{\}a-zA-Z=]", "").Split(',');
                positionSave = new System.Drawing.Point(int.Parse(g[0]), int.Parse(g[1]));
            }
        }
        public static string scanLine(StreamReader sr)
        {
            string tempLine = sr.ReadLine();
            int i = (tempLine.IndexOf("=") + 1);
            return tempLine.Substring(i);
        }
    }
}
