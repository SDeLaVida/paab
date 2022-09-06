public class Calendar
{
    public bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            throw new InvalidYearException1();
        }
        return DateTime.IsLeapYear(year);
    }

    public void IsUserInputLeapYear()
    {
        try
        {
            var userInput = Console.ReadLine();
            var year = int.Parse(userInput ?? "0");
            var calendar = new Calendar();
            Console.WriteLine(calendar.IsLeapYear(year) ? "yay" : "nay");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Please type a valid number.");
            IsUserInputLeapYear();
        }
        catch (InvalidYearException1)
        {
            Console.WriteLine("Please type a year after 1582.");
            IsUserInputLeapYear();

        }

    }
}