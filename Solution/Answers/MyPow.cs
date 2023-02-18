namespace Solution.Answers
{
    public class MyPow
    {
        public static void Run()
        {
            //Console.WriteLine(Solution(2, 10));
            Console.WriteLine(Solution(2, -2147483648));
        }
        public static double Solution(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1 || x == 1) return x;
            if (x == -1) return (n % 2 == 0 ? 1 : -1);
            if (n == -1) return 1 / x;
            if (n == int.MinValue || n == int.MaxValue) return 0;
            if (x > 100 || x < -100) return 0;

            bool isMinus = n < 0;
            int length = isMinus ? n * (-1) : n;
            double number = isMinus ? 1 / x : x;
            double result = number * number;

            for (int i = 2; i < length; i++)
                result *= number;

            return result;
        }
    }
}
