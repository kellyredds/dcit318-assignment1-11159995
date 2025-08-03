using System;

class TriangleType
{
    static void Main()
    {
        //Portion where each side of the triangle is inputted
        Console.Write("Enter side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
//Conditional to assess if the sides are positive and if they form a valid triangle
        //If the sides are positive, it checks if they can form a triangle and determines its type
       
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Sides must be positive numbers.");
        }
        // The conditional to assess if the sides form a valid triangle
        else if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
        // The conditional to assess if the triangle is Equilateral
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
                // The conditional to assess if the triangle is Isosceles
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            // The conditional to assess if the triangle is Scalene
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            // If the sides do not form a valid triangle, it prints an error message
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
    }
}