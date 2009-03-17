using System;

namespace TaikodomStats.DataSL.Localization
{
    public class DataScopeLocalization: IDisposable
    {
        [ThreadStatic]
        private static string currentCultureName;

        public static string CurrentCultureName
        {
            get { return currentCultureName; }
            private set { currentCultureName = value; }
        }

        public DataScopeLocalization()
        {
            CurrentCultureName = null;
        }

        public DataScopeLocalization(string initialCultureName)
        {
            CurrentCultureName = initialCultureName;
        }

        public void Reset()
        {
            CurrentCultureName = null;
        }

        public void Setup(string cultureName)
        {
            CurrentCultureName = cultureName;
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        private void Dispose(bool isDispose)
        {
            if (isDispose)
            {
                CurrentCultureName = null;
            }
            // if disposed is not explicit called, then nothing change

        }

        ~DataScopeLocalization()
        {
            Dispose(false);
        }

        #endregion IDisposable
    }
}
