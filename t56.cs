using MyLib;

int getSummRow(int[,] array, int row)
{
    int summ = array[row, 0];
    for (int i = 1; i < array.GetLength(1); i++)
    {
        summ += array[row, i];
    }
    return summ;
}

int rowWithMinElement(int[,] array)
{
    int dimRow = array.GetLength(0);
    int dimCol = array.GetLength(1);
    int rowWithSmallElement = 0;
    int smallElement = getSummRow(array, 0);
    for (int row = 1; row < dimRow; row++)
    {   
        if (smallElement > getSummRow(array, row))
        {
            rowWithSmallElement = row;
            smallElement = getSummRow(array, row);
        }
    }
    return rowWithSmallElement;
}

int[,] testArray = Function.GetArray(4, 4, 0, 9);
Function.PrintArray(testArray);
Console.WriteLine();
int row = rowWithMinElement(testArray);
Console.WriteLine($"Строка с минимальной суммой элементов: {row}");
