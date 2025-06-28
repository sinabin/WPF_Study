namespace UiDesktopAppTest.Interfaces;

public interface IDateTime
{
    // DateTime dateTime = DateTime.Now;  // 반드시 값이 있어야 함
    DateTime? GetCurrentDateTime(); // null 할당 가능 : int, DateTime, bool 등은 기본적으로 null값을 가질 수 없는 데이터 타입이므로  ?(Nullable Value Type)표현을 사용한다
    
}