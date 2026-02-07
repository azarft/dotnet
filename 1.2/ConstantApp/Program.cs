int[,] matrix = 
{
    { 1, 2, 3 },
    { 4, 5, 6 }
    
};

int c_r = matrix.GetUpperBound(0) + 1;
int c_c = matrix.Length / c_r;

System.Console.WriteLine($"Rows: {c_r}, Columns: {c_c}");

for (int i = 0; i < c_r; i++)
{
    for (int j = 0; j < c_c; j++)
    {
        System.Console.Write(matrix[i, j] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();

int[][] jaggedArray = new int[4][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 }; 
jaggedArray[2] = new int[] { 6, 7, 8, 9 };
jaggedArray[3] = new int[] { 10 };

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        System.Console.Write(jaggedArray[i][j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

foreach (var row in jaggedArray)
{
    foreach (var item in row)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

// Write Rank and Dimensions to code
System.Console.WriteLine($"matrix Rank: {matrix.Rank}");
System.Console.WriteLine($"matrix Dimensions: {matrix.GetLength(0)} x {matrix.GetLength(1)}");
System.Console.WriteLine($"jaggedArray Rank: {jaggedArray.Rank}");
System.Console.WriteLine($"jaggedArray Rows: {jaggedArray.Length}");
for (int i = 0; i < jaggedArray.Length; i++)
{
    System.Console.WriteLine($"jaggedArray[{i}] Length: {jaggedArray[i].Length}");
}