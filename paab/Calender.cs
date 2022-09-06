public class Calendar
{
    public bool IsLeapYear(int year)
    {
        //throw new NotImplementedException();
        return DateTime.IsLeapYear(year);
    }

    public void IsUserInputLeapYear()
    {
        var userInput = Console.ReadLine();

        var year = int.Parse(userInput ?? "0");

        var calendar = new Calendar();

        Console.WriteLine(calendar.IsLeapYear(year) ? "yay" : "nay");
    }
}