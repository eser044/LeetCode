namespace Solution.Answers
{
    public class MaxArea
    {
        public static void Run()
        {
            int[] heightArray = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            Console.WriteLine(Solution(heightArray));
        }
        public static int Solution(int[] height)
        {
            int maxArea = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int minHeight = height[i] < height[j] ? height[i] : height[j];
                int area = (j - i) * minHeight;
                maxArea = maxArea > area ? maxArea : area;

                if (height[i] < height[j])
                    i++;
                else
                    j--;
            }

            return maxArea;
        }
    }
}
