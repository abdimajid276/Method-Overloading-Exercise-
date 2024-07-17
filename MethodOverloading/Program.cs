namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool IsCurrency)
        {
            var sum = numOne + numTwo;
            if (IsCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (IsCurrency && sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
    }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1 , 1, IsCurrency:true));
        }
    }
}
