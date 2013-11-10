using System;
using System.IO;
using WpfApp.Entities;

namespace WpfApp.BL
{
    class SettingsService
    {
        public virtual void SaveError(Settings settings)
        {
            //simulate failing save to file 
            throw new FileNotFoundException("Access denied to file Settings.xml.");
        }

        public virtual void SaveCriticalFail(Settings settings)
        {
            //simulate critical fail 
            throw new Exception("Critical error occured.");
        }

        public virtual void SaveCorrect(Settings settings)
        {
            //simulate successful save to file 
            Storage.Settings = settings;
        }
    }
}
