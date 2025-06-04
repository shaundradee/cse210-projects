using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int selectedOpt = 0;

        while (selectedOpt != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity \n 2. Reflection Activity \n 3. Listing Activity \n 4. Quit");
            Console.Write("Select an option from the menu: ");
            selectedOpt = int.Parse(Console.ReadLine());

            if (selectedOpt == 1)
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.DisplayStartMessage();
                breathe.SetDuration();
                breathe.RunBreathingActivity();
                breathe.DisplayEndMessage();
            }
            else if (selectedOpt == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.DisplayStartMessage();
                reflect.SetDuration();
                reflect.RunReflectingActivity();
                reflect.DisplayEndMessage();
            }
            else if (selectedOpt == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartMessage();
                listing.SetDuration();
                listing.RunListingActivity();
                listing.DisplayEndMessage();
            }
        }
        Console.WriteLine("Thanks for practicing mindfulness! Come back any time you need a moment to reset.\n");

    }
}