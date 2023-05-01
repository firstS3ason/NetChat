using NetChat.WPF.ViewModels.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NetChat.Application.ViewModels.Base
{
    internal abstract class ViewModelBase : INotifyPropertyChanged, IDisposable, IViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        private bool _disposed = false;
        protected virtual bool Set<T>(T value, ref T property, [CallerMemberName] string propertyName = null)
        {
            if (Equals(property, value)) return false;
            property = value;
            OnPropertyChanged(propertyName);

            return true;
        }
        protected virtual void Dispose(bool isDisposed)
        {
            if (!isDisposed && !_disposed) return;
            _disposed = true;
        }
        public void Dispose()
        {
           
        }

    }
}
