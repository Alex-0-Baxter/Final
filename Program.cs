// See https://aka.ms/new-console-template for more information

while(true)
{
    Console.WriteLine("What is your birthday? (mm/dd/yyyy format and q to quit) ");

    var usrBirthday = Console.ReadLine();
    if (usrBirthday == "q"){
        break;
    }
    var today = DateTime.Now;


    DateTime realDay;
    DateTime.TryParse(usrBirthday, out realDay);

    var dayAge = today - realDay;

    int intday = (int)dayAge.Days;

    Console.WriteLine($"THE LORD HAS GIVEN YOU {intday} DAYS!");

    if (dayAge.Days < 26809)
    {
        Console.WriteLine($"You may only have {26809-dayAge.Days} left. use them well"); //number of days based on avg life expectancy of 73.4 years
    }
    else
    {
        Console.WriteLine("You beat the odds.");
    }

}