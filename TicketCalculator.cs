using System;

class TicketPriceCalculator
{
    static void Main()
    {
        //The point user is asked for age input
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;
//The conditional to assess the integer value of the input and charge 10gh
        if (int.TryParse(input, out age) && age >= 0)
        {
            int ticketPrice = 10;
//The conditional to assess if integer value is equal to or greater than 65years and offer 7cedis discount 
            if (age >= 65)
            {
                ticketPrice -= 7;
                Console.WriteLine("You get a 7 cedis discount.");
            }
            //The conditional to assess if integer value is equal to or less than 12 years and offer 7cedis discount
            else if (age <= 12)
            {
                ticketPrice -= 7;
                Console.WriteLine("You get a 7 cedis discount.");
            }
            else
            // The conditional to assess if integer value neither fall above 65 or below 12years and print out ''no discount applied''            {
                Console.WriteLine("No discount applied.");
            }
// Where the ticket price is printed out
            Console.WriteLine($"Your ticket price is: {ticketPrice} cedis");
        }
        else
        {
            // If the input is not a valid integer, print an error message
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
