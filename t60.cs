int[] GetRndArray(int dim)
{
    int[] array = new int[dim];

    bool Find(int number, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (array[i] == number) { return true; }
        }
        return false;
    }

    Random rnd = new Random();
    for (int i = 0; i < dim; i++)
    {
        do
        {
            array[i] = rnd.Next(10, 100);
        }
        while (Find(array[i], i));
    }
    return array;
}
int[,,] GetArray3D(int dim)
{
    int[] randomArray = GetRndArray(dim * dim * dim);
    int[,,] array = new int[dim, dim, dim];
    int indexRndArray = 0;
    for (int i = 0; i < dim; i++)
    {
        for (int j = 0; j < dim; j++)
        {
            for (int k = 0; k < dim; k++)
            {
                array[i, j, k] = randomArray[indexRndArray++];
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    int dim = array.GetLength(0);
    for (int k = 0; k < dim; k++)
    {
        for (int i = 0; i < dim; i++)
        {
            for (int j = 0; j < dim; j++)
            {
                Console.Write($"{array[i, j, k],2}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] myArray = GetArray3D(2);
PrintArray(myArray);
