//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Console.Write("Введите размерность m массива: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите размерность n массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//double[,] randomArray = new double[m,n];
//Console.Write("Введите позицию строки: ");
//int m2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите позицию столбца: ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//void mas(int m, int n)
//{
//int i,j;
//Random rand = new Random();
//for (i = 0; i < m; i++)
//{
//Console.WriteLine();
//for (j = 0; j < n; j++)
//{
//randomArray[i,j] = rand.NextDouble();
//Console.Write($"{randomArray[i,j]:F2} ");
//}
//Console.WriteLine();
//}
//}
//mas(m,n);
//if (m2<1 || n2<1)
//Console.Write("Позиции строк не могут быть отрицательными");
//else if (m2 <= m+1 && n2 <= n+1)
//Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
//else Console.Write("Такого элемента нет в массиве");


//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//var array = new int[3, 3]
//            { { 4, 3, 1 },
//              { 2, 6, 9 },
//              { 4, 6, 2 },
//            };
//            for(int i = 0; i < array.GetLength(1); i++)
//            {
//                var tmp = array[2, i];
//                array[2, i] = array[0, i];
//                array[0, i] = tmp;
//            }
//            for(int i = 0; i < array.GetLength(0); i++)
//            {
//                for(int j = 0; j < array.GetLength(1); j++)
//                {
//                    Console.Write(array[i,j] + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey(true);




//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Console.Write("Введите размерность m массива: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите размерность n массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[,] randomArray = new int[m,n];
//
//void mas(int m, int n)
//{
//int i,j;
//Random rand = new Random();
//for (i = 0; i < m; i++)
//{
//for (j = 0; j < n; j++)
//{
//randomArray[i,j] = rand.Next(1,9);
//}
//}
//}
//
//void printm(int[,] array)
//{
//int i,j;
//for (i = 0; i < array.GetLength(0); i++)
//{
//Console.WriteLine();
//for (j = 0; j < array.GetLength(1); j++)
//{
//Console.Write($"{array[i,j]} ");
//}
//Console.WriteLine();
//}
//}

//mas(m,n);
//Console.WriteLine("\nИсходный массив: ");
//printm(randomArray);

//int SumLine(int[,] array, int i)
//{
//int sum = array[i,0];
//for (int j = 1; j < array.GetLength(1); j++)
//{
//sum += array[i,j];
//}
//return sum;
//}

//int minSum = 1;
//int sum = SumLine(randomArray, 0);
//for (int i = 1; i < randomArray.GetLength(0); i++)
//{
//if (sum > SumLine(randomArray, i))
//{
//sum = SumLine(randomArray, i);
//minSum = i+1;
//}
//}
//Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");



//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

//пока не осилил