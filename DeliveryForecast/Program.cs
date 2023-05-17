DateTime dateTime;
DateOnly date;
TimeOnly time;
DayOfWeek day;
DateOnly result;

Console.WriteLine("Enter the date and time of delivery (dd.MM.yyyy HH:mm):");
try
{
    dateTime = Convert.ToDateTime(Console.ReadLine());
    date = DateOnly.Parse(dateTime.ToShortDateString());
    time = TimeOnly.Parse(dateTime.ToShortTimeString());
    day = dateTime.DayOfWeek;

    if (day == DayOfWeek.Sunday)
    {
        result = date.AddDays(1);
    }
    else if (day == DayOfWeek.Saturday)
    {
        result = date.AddDays(2);
    }
    else if (day == DayOfWeek.Friday && time > TimeOnly.Parse("12:00"))
    {
        result = date.AddDays(3);
    }
    else if (day == DayOfWeek.Thursday && time > TimeOnly.Parse("12:00"))
    {
        result = date.AddDays(1);
    }
    else if (day == DayOfWeek.Wednesday && time > TimeOnly.Parse("12:00"))
    {
        result = date.AddDays(1);
    }
    else if (day == DayOfWeek.Tuesday && time > TimeOnly.Parse("12:00"))
    {
        result = date.AddDays(1);
    }
    else if (day == DayOfWeek.Monday && time > TimeOnly.Parse("12:00"))
    {
        result = date.AddDays(1);
    }
    else
    {
        result = date;
    }

    Console.WriteLine("Estimated delivery date: " + result);
}
catch
{
    Console.WriteLine("Invalid input format!");
}