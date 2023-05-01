using NetChat.Application.ViewModels.Base;

namespace NetChat.WPF.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        //------------------------------------------------------------------------------------------------------------------\\
        #region Properties
        private string _titleName = "NewApp";
        public string titleName
        {
            get => _titleName;
            set => Set(value, ref _titleName);
        }
        #endregion
        //------------------------------------------------------------------------------------------------------------------\\
        public MainWindowViewModel()
        {

        }
        //------------------------------------------------------------------------------------------------------------------\\
        #region Commands

        #endregion
    }
}
