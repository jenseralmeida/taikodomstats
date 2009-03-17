using System.Collections.Generic;
using System.Globalization;

namespace TaikodomStats.DataSL.Localization
{
    public class LocalizableData
    {
        public LocalizableData()
        {
            localizablePropertyByPropertyName = new Dictionary<string, LocalizableProperty>();
        }

        private readonly Dictionary<string, LocalizableProperty> localizablePropertyByPropertyName;
        public object this[string propertyName]
        {
            get
            {
                var localizableProperty = localizablePropertyByPropertyName[propertyName];
                if (localizableProperty == null)
                    return null;
                return localizableProperty[CultureInfo.CurrentUICulture.Name];
            }
            set
            {
                var localizableProperty = localizablePropertyByPropertyName[propertyName];
                if (localizableProperty == null)
                    return;
                localizableProperty[CultureInfo.CurrentUICulture.Name] = value;
            }
        }

    }
}