using System.Windows.Media;
using UiDesktopAppTest.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace UiDesktopAppTest.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel> // 이러한 partial class 구조는 xaml과 cs파일이 하나의 클래스를 구성하게 해준다.
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            // 아래와 같이 xaml마다 코드 비하인드에서 viewModel을 가져오니까
            // 생성자 쪽에서  아래와 같이 이벤트를 달아준다.
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            
            InitializeComponent(); //InitializeComponent()는 XAML에서 정의한 UI 요소들을 실제 C# 객체로 메모리에 올리는 작업을 한다.
            
        }
        
        // 이런식으로 ViewModel과 코드비하인드 사이를 연결을 하여 ViewLogic을 처리할 수 있다.
        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Text":
                    // btnClickMe: DashboardPage.xaml에서 x:Name="btnClickMe"로 정의된 Button으로 
                    this.btnClickMe.Background = new SolidColorBrush(Colors.Red); // this: 현재 클래스인 DashboardPage의 인스턴스를 가리킨다.
                    break;
            }
        }
    }
}
