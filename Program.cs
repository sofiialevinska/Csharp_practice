using System;

namespace hw4
{
    class MainClass
    {

        private static void DateDiff(DateTime date1, DateTime date2)
        {
            int day1 = date1.Day;
            int month1 = date1.Month;
            int year1 = date1.Year;

            int day2 = date2.Day;
            int month2 = date2.Month;
            int year2 = date2.Year;

            int diff = 0;

            for (int year = year1 + 1; year <= year2; year++)
            {
                if (IsLeapYear(year))
                {
                    diff += 366;
                }
                else
                {
                    diff += 365;
                }
            }

            if (month2 > month1)
            {
                for (int month = month1 + 1; month < month2; month++)
                {
                    diff += DaysInMonth(month, year2);
                }
                diff = diff + day2 + DaysInMonth(month2, year1) - day1;
            }


            if (month2 < month1)
            {
                for (int month = month1 - 1; month > month2; month--)
                {
                    diff -= DaysInMonth(month, year2);
                }
                diff = diff - day1 - DaysInMonth(year1, year1) + day1;
            }

            if (diff >= 0)
            {
                Console.WriteLine("The difference in days between dates is {0} days", diff);
            }
            else
            {
                Console.WriteLine("The birth day is in the future. The difference in days between dates is 0 days");
            }
        }

        private static void Age (DateTime date1, DateTime date2)
        {
            int day1 = date1.Day;
            int month1 = date1.Month;
            int year1 = date1.Year;

            int day2 = date2.Day;
            int month2 = date2.Month;
            int year2 = date2.Year;

            int ageYear = 0;
            int ageMonth = 0;
            int ageDay = 0;

            ageYear = year2 - year1;

            if (month2 > month1)
            {
                ageMonth = month2-month1;
            }

            if (month2 < month1)
            {
                ageYear --;
                ageMonth = month1 - month2;
            }

            if (day2>day1)
            {
                ageDay = day2 - day1;
            }

            if (day1>day2)
            {
                ageDay = day1 - day2;
            }

            if (date2 >= date1)
            {
                Console.WriteLine("The difference dates is {0} years, {1} month, {2} days", ageYear, ageMonth, ageDay);
            }
            else
            {
                Console.WriteLine("The birth day is in the future. The difference dates is {0} years, {1} month, {2} days", ageYear, ageMonth, ageDay);
            }

        }

            private static Boolean IsLeapYear(int year)
        {
            Boolean isLeapYear = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            return isLeapYear;
        }

        private static int DaysInMonth(int month, int year)
        {
            int days = 0;
            switch (month)
            {
                case 01:
                    days = 31;
                    break;
                case 02:
                    if (IsLeapYear(year))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                case 03:
                    days = 31;
                    break;
                case 04:
                    days = 30;
                    break;
                case 05:
                    days = 31;
                    break;
                case 06:
                    days = 30;
                    break;
                case 07:
                    days = 31;
                    break;
                case 08:
                    days = 31;
                    break;
                case 09:
                    days = 30;
                    break;
                case 10:
                    days = 31;
                    break;
                case 11:
                    days = 30;
                    break;
                case 12:
                    days = 31;
                    break;
            }
            return days;
        }

        public static void Main(string[] args)
        {
            int birthYear = 0;
            int birthMonth = 0;
            int birthDay = 0;

            do
            {
                try
                {
                    Console.WriteLine("Please enter your birth date");
                    Console.WriteLine("Year (4 digits):");
                    birthYear = int.Parse(Console.ReadLine());
                    Console.WriteLine("Month (2 digits):");
                    birthMonth = int.Parse(Console.ReadLine());
                    Console.WriteLine("Day (2 digits):");
                    birthDay = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message + " Please try again.\n");
                }
            } while (birthDay == 0);

            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            DateTime currentDate = DateTime.Now;

            DateDiff(birthDate, currentDate);
            Age(birthDate, currentDate);
        }
    }
}
