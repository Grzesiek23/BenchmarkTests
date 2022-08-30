namespace BenchmarkTests.DateTime;

public class DateParser
{
    public int GetYearFromDateTime(string dateTimeAsString)
    {
        var dateTime = System.DateTime.Parse(dateTimeAsString);
        return dateTime.Year;
    }
}