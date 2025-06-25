namespace UiDesktopAppTest.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {

        [ObservableProperty]
        private string? text;

        // 이 변수가 Changed 되었다는 걸 알려주는 메서드가 있다. RaisePropertyChanged() 이런 메서드
        // 이런게 프리즘과 같은 프레임워크는 이렇게 되어있는데 
        // wpf ui에서는 자동으로 생성되는 코드들이 있다. 
        // 그게 바로 ObservableProperty라고 선언을 해주면 wpf-ui 자체의 source generator가 해당 property의 get,set 관련된 메서드등을 자동으로 생성해준다
        
        [ObservableProperty]
        private int _counter = 0;


        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
            // 그래서 property 및 get,set 메서드등을 자동으로 생성해주기 때문에
            // 어떤 property가 정의되어있지 않아도 아래와 같이 해당 property를 가져다가 쓸 수 있다.
            this.Text = "test임";

            // 그래서 이런식으로 변수를 할당하고 해당 변수를 Tracking하고 싶은 경우
            // 즉 DataBinding을 걸고 싶은 경우에는  ObservableProperty 라는 어노테이션? 비슷한 저걸 달아주면 된다.


        }
    }
}
