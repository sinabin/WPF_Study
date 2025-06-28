using UiDesktopAppTest.Interfaces;

namespace UiDesktopAppTest.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly IDateTime _iDateTime;

        [ObservableProperty] private string currentTime = ""; // ←backing field (실제 데이터 저장소)

        // 이 변수가 Changed 되었다는 걸 알려주는 메서드가 있다. RaisePropertyChanged() 이런 메서드
        // 이런게 프리즘과 같은 프레임워크는 이렇게 되어있는데 
        // wpf ui에서는 자동으로 생성되는 코드들이 있다. 
        // 그게 바로 ObservableProperty라고 선언을 해주면 wpf-ui 자체의 source generator가 해당 property의 get,set 관련된 메서드등을 자동으로 생성해준다
        
        [ObservableProperty]
        private int _counter = 0;
        
        public DashboardViewModel(IDateTime dateTime)
        {
            _iDateTime = dateTime;
        }

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
            // 그래서 property 및 get,set 메서드등을 자동으로 생성해주기 때문에
            // 어떤 property가 정의되어있지 않아도 아래와 같이 해당 property를 가져다가 쓸 수 있다.

            // 그래서 이런식으로 변수를 할당하고 해당 변수를 Tracking하고 싶은 경우
            // 즉 DataBinding을 걸고 싶은 경우에는  ObservableProperty 라는 어노테이션? 비슷한 저걸 달아주면 된다.
            
        }

        // Command로서 사용하고싶다면 이와 같이 RelayCommand라고 attribute를 붙여주면 된다.
        [RelayCommand]
        private void OnTextChanged()
        {
            // this.currentTime = this._iDateTime.GetCurrentDateTime().ToString(); 이렇게 하면   backing field (실제 데이터 저장소)를 의미하는 것이므로
            // 아래와 같이 대문자로 적어줘야 UI에 반영되는 즉 Source Generator가 자동으로 생성한 UI바인딩용 프로퍼티를 사용하게 되는 것이다.
            this.CurrentTime = this._iDateTime.GetCurrentDateTime().ToString(); // MVMM
        }
    }
}
