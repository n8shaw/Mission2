using Mission_2;
internal class Program
{
    private static void Main(string[] args)
    {
        DiceRoller dr = new DiceRoller();
        int rollCount = 0;
        int[] results = new int[11];

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolles would you like to simulate?");


        rollCount = int.Parse(System.Console.ReadLine());

        results = dr.RollDie(rollCount);

        for (int i = 0; i < results.Length; i++)
        {
            // Calculate the percentage of rolls for the current result
            double percentage = (results[i] / (double)rollCount) * 100;

            // Print the result and corresponding stars
            System.Console.Write((i + 2) + ": ");

            // Print a '*' for every 1%
            int numStars = (int)Math.Floor(percentage); // Use Ceiling to round up to the nearest integer
            for (int j = 0; j < numStars; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine(); // Move to the next line after printing stars
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}