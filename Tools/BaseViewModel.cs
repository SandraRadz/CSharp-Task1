using Radzievska_Homework1.Properties;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Radzievska_Homework1.Tools
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
