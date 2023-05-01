

using System.Runtime.CompilerServices;

namespace NetChat.WPF.ViewModels.Base
{
    internal interface IViewModel
    {
        public void OnPropertyChanged([CallerMemberName] string propertyName = null);
    }
}
