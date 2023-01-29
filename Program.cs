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
            Random random = new Random();
            int dieroll = random.Next(0,7);
            Console.WriteLine("Number of die roll" +dieroll);
        }
    }
}