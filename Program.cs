﻿// See https://aka.ms/new-console-template for more information

while(true)
{
    Console.WriteLine("What is your birthday? (mm/dd/yyyy)");

    var usrBirthday = Console.ReadLine();
    var today = DateTime.Now;


    DateTime realDay;
    DateTime.TryParse(usrBirthday, out realDay);

    var dayAge = today - realDay;

    Console.WriteLine($" THE LORD HAS GIVEN YOU {dayAge.Days} DAYS!");

    if (dayAge.Days < 26809)
    {
        Console.WriteLine($"you may only have {26809-dayAge.Days} left. use them well"); //number of days based on avg life expectancy of 73.4 years
    }
    else
    {
        Console.WriteLine("you beat the odds.");
    }

}