/*
 * Problem 15.* Age after 10 Years
 * 
 *Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */
using System;

class AgeAfterTenYears
{
    static void Main()
    {
        //Specify exactly how to interpred the date and time
        IFormatProvider culture = new System.Globalization.CultureInfo("bg-BG", true);

        //Get the current date and time in the specified format
        DateTime Current = DateTime.Today;

        //Promp the user to enter his or her date of birth
        Console.WriteLine("Please, enter your date of birth in the format dd/mm/yyyy :");
        DateTime Entered = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("You have entered the following birth date: " + Entered);

        //Get the separate Date elements for the Current Date and the Birthday Date
        int b_day = Entered.Day;
        int b_month = Entered.Month;
        int b_year = Entered.Year;

        int c_day = Current.Day;
        int c_month = Current.Month;
        int c_year = Current.Year;

        //Check validity of entered birth date
        if (Entered > Current)
        {
            Console.WriteLine("Not valid birth date");
            return;
        }

        //Use conditional statements to assess how old you are now and in 10 years
        if (b_month == c_month)
        {
            if (b_day <= c_day)
            {
                Console.WriteLine("Right now you are " + (c_year - b_year) + " years old.");
                Console.WriteLine("In ten years you will be " + (c_year - b_year + 10) + " years old");
            }
            else if (b_day > c_day)
            {
                Console.WriteLine("Right now you are " + (c_year - b_year - 1) + " years old.");
                Console.WriteLine("In ten years you will be " + (c_year - b_year + 10 - 1) + " years old");
            }
        }

        else if (b_month < c_month)
        {
            Console.WriteLine("Right now you are " + (c_year - b_year) + " years old.");
            Console.WriteLine("In ten years you will be " + (c_year - b_year + 10) + " years old");
        }
        else
        {
            Console.WriteLine("Right now you are " + (c_year - b_year - 1) + " years old.");
            Console.WriteLine("In ten years you will be " + (c_year - b_year + 10 - 1) + " years old");
        }


       
    }
}