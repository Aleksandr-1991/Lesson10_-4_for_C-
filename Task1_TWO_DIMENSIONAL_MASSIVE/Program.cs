//(блок) 
/*
string [,] table = new string [2, 5];
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// String.Empty //- помним что так объявляется пустая строка.
table[1, 2] = "Слово"; 
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"~{table[rows, columns]}~ ");
    }
Console.WriteLine();
}                            //*/

//(блок) /*
int [,] matrix = new int [3, 4];
void PrintArray(int [,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // .GetLength(0) - возвращает кол-во строк массива.
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // .GetLength(1) - возвращает кол-во столбцов.
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);                                         //*/