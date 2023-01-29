namespace SnakeLadderProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake ladder problem");
            int position = 0;
            int player = 1;
            Console.WriteLine("Position" + position);
            int dieRoll = 0;
            while (position != 100)
            {


                Random random = new Random();
                int dieroll = random.Next(0, 7);
                Console.WriteLine("Number of die roll" + dieroll);
                int option = random.Next(3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Play Snake");
                        position -= 1;
                        break;
                    case 2:
                        Console.WriteLine("Play Ladder");
                        position++;
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }
            }
            if (position < 0)
            {
                position = 0;
            }
        }
    }
}