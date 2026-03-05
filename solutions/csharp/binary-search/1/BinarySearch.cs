public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int offset = 0;
        int[] working = input;
        while (working.Length > 0)
        {
            int mid = working.Length / 2;
            int midValue = working[mid];
            if (value == midValue)
            {
                offset += mid;
                return offset;
            }

            else if (value < midValue)
            {
                working = working[0..mid];
            }
            else
            {
                working = working[(mid+1)..working.Length];
                offset += mid+1;
            }
        }
        return -1;
    }
}