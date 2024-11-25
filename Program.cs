string date = "26/11/2024";
DateOnly date1 = DateOnly.ParseExact(date, "d/MM/yyyy");
Console.WriteLine($"Дата(ParseExact): {date1}");

string date2 = "2024-11-26";
DateOnly date3 = DateOnly.Parse(date);
Console.WriteLine($"Дата(Parse): {date1}");

string time = "06:51:00";
if (TimeOnly.TryParse(time, out TimeOnly time1))
{
    Console.WriteLine($"Время(TryExact): {time1}");
}
else
{
    Console.WriteLine("Что-то не работает");
}

string time2 = "06-51-00";
if (TimeOnly.TryParseExact(time2, "HH-mm-ss", out TimeOnly time3))
{
    Console.WriteLine($"SВремя(TryParseExact): {time3}");
}
else
{
    Console.WriteLine("Что-то не работает");
}