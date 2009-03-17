using System.Collections.Generic;

namespace TaikodomStats.DataSL.Localization
{
    internal class LocalizableProperty
    {
        private LocalizableProperty(string propertyName)
        {
            PropertyName = propertyName;
            CultureValue = new Dictionary<string, object>();
        }

        public string PropertyName { get; set; }

        public Dictionary<string, object> CultureValue { get; private set; }

        public object this[string cultureName]
        {
            get
            {
                return CultureValue[cultureName];
            }
            set
            {
                CultureValue[cultureName] = value;
            }
        }
    }
}
