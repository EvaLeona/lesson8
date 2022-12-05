using MyLib;

void SortRowArray(int[,] sortedArray)
{
    int dimRow = sortedArray.GetLength(0);
    int dimCol = sortedArray.GetLength(1);
    for (int i = 0; i < dimRow; i++)
    {
        bool isSorted; int tempCell;
        do
        {
            isSorted = true;
            for (int j = 1; j < dimCol; j++)
            {
                if (sortedArray[i, j] > sortedArray[i, j - 1])
                {
                    tempCell = sortedArray[i, j];
                    sortedArray[i, j] = sortedArray[i, j - 1];
                    sortedArray[i, j - 1] = tempCell;
                    isSorted = false;
                }
            }
        } while (!isSorted);
    }
}


int[,] myArray = Function.GetArray(4, 4, 0, 9);
Function.PrintArray(myArray);
Console.WriteLine("  -----------------------");
SortRowArray(myArray);
Function.PrintArray(myArray);

