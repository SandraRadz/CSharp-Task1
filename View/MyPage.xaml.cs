using Radzievska_Homework1.ViewModels;
using System.Windows.Controls;

namespace Radzievska_Homework1.View
{
    /// <summary>
    /// Interaction logic for MyPage.xaml
    /// </summary>
    public partial class MyPage : UserControl
    {
        public MyPage()
        {
            InitializeComponent();
            DataContext = new MyPageViewModel();
        }
    }
}
