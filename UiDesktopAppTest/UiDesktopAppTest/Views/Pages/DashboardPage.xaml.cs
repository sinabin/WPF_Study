using UiDesktopAppTest.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace UiDesktopAppTest.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            // 아래와 같이 xaml마다 코드 비하인드에서 viewModel을 가져오니까
            // 생성자 쪽에서  아래와 같이 이벤트를 달아준다.
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;


            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
