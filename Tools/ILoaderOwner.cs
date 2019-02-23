using System.ComponentModel;
using System.Windows;

namespace Radzievska_Homework1
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
