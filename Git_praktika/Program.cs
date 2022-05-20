namespace Git_praktika
{
    static class Program
    {
        public static void Main(string[] args)
        {
            
        }

        static void Sum(int[] arr)
        {
            var sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}