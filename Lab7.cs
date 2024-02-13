using System;

class Program
{
    static void Main(string[] args)
    {
        int m, n;
        Console.Write("Введіть кількість рядків (m): ");
        if (int.TryParse(Console.ReadLine(), out m))
        {
            Console.Write("Введіть кількість стовпців (n): ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[,] matrixA = InputMatrix(m, n, "Матриця A");
                int[,] matrixB = InputMatrix(m, n, "Матриця B");

                Console.WriteLine("Матриця A:");
                PrintMatrix(matrixA);

                Console.WriteLine("Матриця B:");
                PrintMatrix(matrixB);

                int[,] sumMatrix = AddMatrices(matrixA, matrixB);
                int[,] diffMatrix = SubtractMatrices(matrixA, matrixB);
                int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);
                int productOfElementsA = MultiplyElements(matrixA);
                int productOfElementsB = MultiplyElements(matrixB);

                Console.WriteLine("Сума матриць A і B:");
                PrintMatrix(sumMatrix);

                Console.WriteLine("Різниця матриць A і B:");
                PrintMatrix(diffMatrix);

                Console.WriteLine("Добуток матриць A і B:");
                PrintMatrix(productMatrix);

                Console.WriteLine("Добуток всіх елементів матриці A: " + productOfElementsA);
                Console.WriteLine("Добуток всіх елементів матриці B: " + productOfElementsB);
            }
            else
            {
                Console.WriteLine("Неправильний формат введення для кількості стовпців (n).");
            }
        }
        else
        {
            Console.WriteLine("Неправильний формат введення для кількості рядків (m).");
        }
    }

    static int[,] InputMatrix(int m, int n, string name)
    {
        Console.WriteLine($"Введіть елементи матриці {name}:");
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{name}[{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int m = matrixA.GetLength(0);
        int n = matrixA.GetLength(1);
        int[,] result = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int m = matrixA.GetLength(0);
        int n = matrixA.GetLength(1);
        int[,] result = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int m = matrixA.GetLength(0);
        int n = matrixA.GetLength(1);
        int[,] result = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = matrixA[i, j] * matrixB[i, j];
            }
        }

        return result;
    }

    static int MultiplyElements(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int product = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                product *= matrix[i, j];
            }
        }

        return product;
    }
}
