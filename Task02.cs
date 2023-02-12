public static class Task02
{
    public static void Answer(int[,] arr)
    {
        int rowIndex = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                rowIndex = i;
            }
        }
        System.Console.WriteLine($"Строка с наименьшей суммой: {rowIndex + 1}");
    }

}