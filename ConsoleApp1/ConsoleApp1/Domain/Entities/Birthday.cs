namespace ConsoleApp1.Domain.Entities
{
    public struct Birthday
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public int Day { get; set; }

        public Birthday(int year, int month, int day)
        {
            if (day > 0 && day<= 31 && month >= 1 && month <= 12 && year >= 1 && year <= DateTime.Now.Year)
            {
                Year = year;
                Month = month;
                Day = day;
            }
        }
        public enum Days
        {
            Monday = 0,
            Tuesday = 1, 
            Wednesday  = 2,
            Thursday  = 3,
            Friday = 4,
            Saturday =5,
            Sunnday = 6
        }
        public enum Months
        {
            January = 1,
            February =2,
            March =3 ,
            April =4,
            May =5,
            June =6,
            July =7,
            August =8,
            September =9,
            October =10,
            November =11,
            December = 12
        }
        public static int getNumberOfDays(int m, int y)
        {
            int leap = (1 - (y % 4 + 2) % (y % 4 + 1)) * ((y % 100 + 2) % (y % 100 + 1)) + (1 - (y % 400 + 2) % (y % 400 + 1));

            return 28 + ((m + (m / 8)) % 2) + 2 % m + ((1 + leap) / m) + (1 / m) - (leap / m);
        }
        public int DaysToBirthday()
        {
            var today = DateTime.Today;
            var birthdayThisYear = new DateTime(today.Year, Month, Day);

            if (birthdayThisYear < today)
                birthdayThisYear = birthdayThisYear.AddYears(1);

            return (birthdayThisYear - today).Days;
        }

       public string DayOfWeek()
        {
            DateTime dateValue = new DateTime(Year, Month, Day);
            return $"{((int)dateValue.DayOfWeek)}";
        }
        public void ShowBirthday()
        {
            Console.WriteLine($"{Day}.{Month}.{Year}");
        }
    }
}
