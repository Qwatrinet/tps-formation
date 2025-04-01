namespace FizzBuzzMethodeRache
{
    public class Program
    {
        public static string FizzBuzz(int number)
        {

            if (number < 1)
            {
                throw new ArgumentException("Le nombre doit être positif!");
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        public static string FB(int min, int max)
        {
            string result = "";
            for (int i = min; i <= max; i++)
            {
                result += FizzBuzz(i) + " ";
            }
            return result;
        }
        public static void Main(string[] args)
        {


            Console.WriteLine(FB(1, 100));
        }
    }
}
