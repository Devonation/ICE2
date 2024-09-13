namespace OverloadingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(3, 4);
            Console.WriteLine();
            Console.WriteLine($"+ : {+a}");
            Console.WriteLine($"- : {-a}");
            Console.WriteLine($"++ : {++a}");

            if (new Fraction(3, 4) == a) 
            {
                Console.WriteLine("They are not equal");
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }
    }
}
