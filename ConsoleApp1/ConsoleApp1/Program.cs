

using ConsoleApp1.Domain.Entities;

var bh = new Birthday() { Day = 15,Month = 7,Year = 2009};
Console.WriteLine(bh.DaysToBirthday());

Console.WriteLine(bh.DayOfWeek());