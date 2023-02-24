// задача 93 дайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.WriteLine("Введите параметры матриц указав их разиер и диапазон случайных значений:");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы: ");
int range = InputNumbers("Введите число для определения максимального диапазона случайных ");

int[,] oneMartrix = new int[m, n]; //  вызов первой матрицы
CreateArray(oneMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(oneMartrix);

int[,] twoMartrix = new int[n, p]; //  вызов второй матрицы
CreateArray(twoMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(twoMartrix);

int[,] resultMatrix = new int[m,p];   //  вы3ов метода матрица - произведение
MultiplyMatrix(oneMartrix, twoMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] oneMartrix, int[,] twoMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < oneMartrix.GetLength(1); k++)
      {
        sum += oneMartrix[i,k] * twoMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}