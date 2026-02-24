namespace Exercise4
{
    /// <summary>
    /// Integers Calculation
    /// </summary>
    internal class Location Altitudes
    {
        /// <summary>
        /// Practice with integers calculation, including addition and subtraction in C#.
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // Prompt for and get the altitude for a location as an int.
            int altitudeAlaska = 6190; // Integer variable of Denali, Alaska in meters

            // Prompt for and get the altitude for a second location as an int.
            int altitudeSouthAmerica = 6961; // Integer variable of Aconcagua, South America in meters

            // Calculate the difference in altitude between the two locations.
            int altitudeChange = altitudeSouthAmerica - altitudeAlaska;

            // Display the result in meters.
            Console.WriteLine($"The altitude change from Alaska to South America is {altitudeChange} meters.");
        }
    }
}
