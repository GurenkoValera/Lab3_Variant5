using System;

class Program
{
    static void Main()
    {
        int size = 9;
        int[,] matrix = new int[size, size];
        Random random = new Random();

        // Заполнение матрицы случайными числами от 1 до 10
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(1, 11); // Случайные числа от 1 до 10
            }
        }

        // Вычисление сумм элементов в строках и столбцах, и размещение их на главной диагонали
        for (int i = 0; i < size; i++)
        {
            int rowSum = 0;
            int colSum = 0;

            for (int j = 0; j < size; j++)
            {
                rowSum += matrix[i, j]; // Сумма элементов в строке
                colSum += matrix[j, i]; // Сумма элементов в столбце
            }

            matrix[i, i] = rowSum + colSum; // Размещение суммы на главной диагонали
        }

        // Отображение матрицы на экране
        Console.WriteLine("Матрица:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{matrix[i, j],4} "); // Форматированный вывод
            }
            Console.WriteLine();
        }
    }
}