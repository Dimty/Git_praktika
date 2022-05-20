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
        public static IEnumerator<int> GetEnumerator (this char numb)
        {
            for (int i = 0; i < (int)numb; i++)
            {
                yield return i;
            }
        }
    }
}