namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string slothName = "Zach";
            int howManyPeopleAreFasterThanZach = 0;
            char yippy = '!';
            bool isTheFastest = true;
            double mph = 120.23;
            decimal kph = 193.491429m;
            Console.WriteLine($"I know of a sloth named {slothName} and it is {isTheFastest} that he the fastest being \n" +
                $"on the planet, there are exactly {howManyPeopleAreFasterThanZach} people faster than him. He was once clocked \n" +
                $"going {mph} mph or {kph} kph{yippy}");
        }
    }
}
