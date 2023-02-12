public static class Task03
{
    public static int[,] Answer(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}