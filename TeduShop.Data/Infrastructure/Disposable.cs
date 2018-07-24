using System;

namespace TeduShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        //Overide this to dispose custom object
        protected virtual void DisposeCore() { }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}