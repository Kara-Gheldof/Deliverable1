using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("How many people are we making peanut butter and jelly sandwiches for?");
            string number = Console.ReadLine();

            int sandwiches = int.Parse(number);

            int NumSlices = 2;
            int PBTBS = 2;
            int JellyTSP = 4;

            int sum1 = NumSlices * sandwiches;
            int sum2 = PBTBS * sandwiches;
            int sum3 = JellyTSP * sandwiches;

            // loaf = 28;
            // Jar of PB = 32;
            // Jar of Jelly = 48; 

            int sum4 = sum1 / 28 + 1;
            int sum5 = sum2 / 32 + 1;
            int sum6 = sum3 / 48 + 1;

            if (sum4 < 1) sum4 = 1;
            if (sum5 < 1) sum5 = 1;
            if (sum6 < 1) sum6 = 1;

            Console.WriteLine("You will need: " + sum1 + " slices of bread, " + sum2 + " tablespoons of peanut butter, and " + sum3 + " teaspoons of jelly.");

            Console.WriteLine("This is equal to: " + sum4 + " loaf or loaves of bread, " + sum5 + " jar(s) of peanut butter, and " + sum6 + " jar(s) of jelly.");

            Console.WriteLine("Would you like to restart? Enter y or yes to continue, or enter any other key to exit.");
            input = Console.ReadLine();
        }
        while ((input == "y") || (input == "yes") || (input == "Y") || (input == "Yes"));

        Console.WriteLine("Goodbye");
    }
}