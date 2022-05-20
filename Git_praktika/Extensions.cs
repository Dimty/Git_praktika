namespace Git_praktika
{
    public static class Extensions
    {
        public static IEnumerator<int> GetEnumerator (this int numb)
        {
            for (int i = 10; i > numb; i++)
            {
                yield return i;
            }
        }
    }
}