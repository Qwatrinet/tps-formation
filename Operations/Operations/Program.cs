using Expressions;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition(new Addition(new Entier(2), new Entier(3)), new Entier(4));
            Console.WriteLine(addition.Formate());

        }
    }
}
