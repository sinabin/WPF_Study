using UiDesktopAppTest.Interfaces;

namespace UiDesktopAppTest.Services;

public class DateTimeService : IDateTime
{
    public DateTime? GetCurrentDateTime()
    {
        return DateTime.Now;
    }
}