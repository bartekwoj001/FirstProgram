using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
                    Console.WriteLine("Podaj imię: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Podaj rok urodzenia: ");
                    //var yearOfBirth = int.Parse(Console.ReadLine());
                    var yearOfBirth = GetYearOfBirth();

                    Console.WriteLine("Podaj miesiąc urodzenia: ");
                    //var monthOfBirth = int.Parse(Console.ReadLine());
                    var monthOfBirth = GetMonthOfBirth();

                    Console.WriteLine("Podaj dzień urodzenia: ");
                    //var dayOfBirth = int.Parse(Console.ReadLine());
                    var dayOfBirth = GetDayOfBirth(yearOfBirth, monthOfBirth);

                    Console.WriteLine("Podaj miejsce urodzenia: ");
                    var placeOfBirth = Console.ReadLine();

                    var dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

                    var age = DateTime.Now.Year - dateOfBirth.Year;


                    if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                        age--;

                    Console.WriteLine("\nCześć " + name + ", urodziłeś się w " + placeOfBirth + " i masz " + age + " lat.");

        }

        private static int GetYearOfBirth()
        {
            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Podaj prawidłowy rok urodzenia");
                    continue;
                }

                return year;
            }

        }
        
        private static int GetMonthOfBirth()
        {
            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine(  "Podaj prawidłowy miesiąc urodzenia z zakresu 1-12");
                    continue;
                }
                return month;
            }

        }
        private static int GetDayOfBirth(int year, int month)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day ) || day > DateTime.DaysInMonth(year, month) || day < 1)
                {
                    Console.WriteLine( "Podaj prawidłowy dzień urodzenia.");
                    continue;
                }
                return day; 

            }
        }



    }
}
