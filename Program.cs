namespace SumAverageMaxMinOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 2, 8, 1, 9, 4, 7, 6 }; ;
            int sum = 0;
            double avg = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"sum : {sum}");
            avg = sum / arr.Length;
            Console.WriteLine($"avg : {avg}");

            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty!");
            }

            for (int i = 1;i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

        }
    }
}