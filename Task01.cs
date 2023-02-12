public static class Task01
{
    public static int[,] Answer(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int[] row = new int[arr.GetLength(1)];

            for (int k = 0; k < row.Length; k++)
            {
                row[k] = arr[i, k];
            }

            Array.Sort(row);
            Array.Reverse(row);

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = row[j];
            }
        }
        return arr;
    }
}