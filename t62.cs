internal class Program
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public static int[,] GetArray()
    {
        Direction direct = Direction.Right;
        int[,] array = new int[4, 4];
        int i = 0, j = 0;
        for (int k = 1; k <= 16; k++)
        {
            array[i, j] = k;
            if (k == 16) break;
            switch (direct)
            {
                case Direction.Up:
                    if (i > 0 && array[i - 1, j] == 0)
                    {
                        i--;
                    }
                    else
                    {
                        direct = Direction.Right;
                        j++;
                    }
                    break;
                case Direction.Down:
                    if (i < 3 && array[i + 1, j] == 0)
                    {
                        i++;
                    }
                    else
                    {
                        direct = Direction.Left;
                        j--;
                    }
                    break;
                case Direction.Left:
                    if (j > 0 && array[i, j - 1] == 0)
                    {
                        j--;
                    }
                    else
                    {
                        direct = Direction.Up;
                        i--;
                    }
                    break;
                case Direction.Right:
                    if (j < 3 && array[i, j + 1] == 0)
                    {
                        j++;
                    }
                    else
                    {
                        direct = Direction.Down;
                        i++;
                    }
                    break;
                default:
                    break;
            }
        }
        return array;
    }
    private static void PrintArray(int[,] printableArray)
    {
        int dimRow = printableArray.GetLength(0);
        int dimCol = printableArray.GetLength(1);
        for (int i = 0; i < dimRow; i++)
        {
            for (int j = 0; j < dimCol; j++)
            {
                Console.Write(String.Format("{0,2:D2} ",printableArray[i, j]));
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[,] myArray = GetArray();
        PrintArray(myArray);
    }
}

