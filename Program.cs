namespace Hearin_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.WriteLine("Welcome to my simple hearing test! \n Please note, that this app is made purely for fun and SHOULDN'T be taken seriously and / or as an professional medical opinion. \n");
            Console.WriteLine("You will hear a series of tones, and you will have to determine, if you can hear it. \n Each sound will be played for approx. 5 seconds.");
            Console.WriteLine("Press any other key to start the test or q to exit...");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Q)
            {
                return;
            }
            Console.WriteLine("Great! Let's start the test. \n");
            var frequencies = new int[] { 250, 500, 1000, 2000, 4000, 8000 };
            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.WriteLine($"Frequency: {frequencies[i]} Hz");
                Thread.Sleep(1000); // Wait for 1 second before playing the tone
                Console.WriteLine("You will hear a tone now. \n");
                Console.WriteLine("Press 'y' if you can hear the tone, or any other key if you cannot hear it.");
                Console.Beep(frequencies[i], 5000); // Play the tone for 1 second
                var response = Console.ReadKey(true);
                if (response.Key == ConsoleKey.Y)
                {
                    points++;
                    Console.WriteLine("You can hear it! \n");
                }
                else
                {
                    Console.WriteLine("You cannot hear it. \n");
                }
                Thread.Sleep(1000); // Wait for 1 second before the next tone
            }
            Console.WriteLine($"Test completed! You scored {points} out of {frequencies.Length} points.");
            Console.WriteLine("Thanks for sticking around! Remember, this is just a fun test and not a professional hearing assessment. \n");
            Console.WriteLine("If you have any concerns about your hearing, please consult a medical professional. \n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
