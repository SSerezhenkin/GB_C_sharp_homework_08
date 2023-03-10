int[,] GenerateRandomArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine("Введите номер задачи, где: \n 1 - упорядочить элементы в строке двухмерного массива \n 2 - найти строку с наименьшей суммой элементов \n 3 - перемножить две матрицы");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 1:
        var arr01 = GenerateRandomArray(4, 4);
        PrintArray(arr01);
        var sorted_arr01 = Task01.Answer(arr01);
        System.Console.WriteLine();
        PrintArray(sorted_arr01);
        break;
    case 2:
        var arr02 = GenerateRandomArray(4, 4);
        PrintArray(arr02);
        Task02.Answer(arr02);
        break;
    case 3:
        var matrix01 = GenerateRandomArray(2, 2);
        PrintArray(matrix01);
        System.Console.WriteLine();
        var matrix02 = GenerateRandomArray(2, 2);
        PrintArray(matrix02);
        System.Console.WriteLine();
        var matrix03 = Task03.Answer(matrix01, matrix02);
        PrintArray(matrix03);
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}