//Тема 20. Локальные функции. Домашнее задание.
//Урок 1/2

//Задание 1.
//Напишите функцию, которая принимает два числа и выводит на экран их
//сумму.
//Числа передаются пользователем в переменные, которые затем
//передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится
//на консоль.

//Console.WriteLine("Введите первое число:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int m = int.Parse(Console.ReadLine());
//int Add(int a, int b)
//{
//    return a + b;
//}
//Console.WriteLine("Результат:" + " " + Add(n,m));

//Задание 2.
//Напишите функцию, которая принимает массив целых чисел и возвращает
//среднее значение элементов массива.
//Массив задать явно
//Функция должна возвращать результат, который в последствии выводится
//на консоль

//Random random = new Random();
//int[] mas = new int[random.Next(5,11)];
//for (int i = 0; i < mas.Length; i++)
//{
//	mas[i] = random.Next(10, 100);
//	Console.Write(mas[i]+" ");
//}
//Console.WriteLine($"Среднее арифметическое:{Avg(mas):F2}");
//double Avg(int[] mas)
//{
//    double s = 0;
//	for (int i = 0; i < mas.Length; i++) s += mas[i];
//	return s / mas.Length;
//}

//Тема 20. Локальные функции. Домашнее задание.
//Урок 2/2

//Задача.
//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата
//новый массив суммы.
//2. Поиска максимального значения массива.

//Random random = new Random();
//int[,] mas1 = new int[4,4];
//Console.WriteLine("Первый массив:");
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        mas1[i, j] = random.Next(-50, 50);
//        Console.Write(mas1[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine("второй массив:");
//int[,] mas2 = new int[4, 4];
//for (int i = 0; i < mas2.GetLength(0); i++)
//{
//    for (int j = 0; j < mas2.GetLength(1); j++)
//    {
//        mas2[i, j] = random.Next(-50, 50);
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//int[,] SumArrays(int[,] arr1, int[,] arr2)
//{
//    int[,] result = new int[4, 4];
//    for (int i = 0; i < 4; i++)
//    {
//        for (int j = 0; j < 4; j++)
//        {
//            result[i, j] = arr1[i, j] + arr2[i, j];
//        }
//    }
//    return result;
//}

//int FindMax(int[,] arr)
//{
//    int max = arr[0, 0];
//    for (int i = 0; i < 4; i++)
//    {
//        for (int j = 0; j < 4; j++)
//        {
//            if (arr[i, j] > max)
//            {
//                max = arr[i, j];
//            }
//        }
//    }
//    return max;
//}

//int[,] summedArray = SumArrays(mas1, mas2);
//Console.WriteLine("Сумма двух массивов:");
//PrintArray(summedArray);

//int maxValue = FindMax(summedArray);
//Console.WriteLine("Максимальное значение в массиве: " + maxValue);

//void PrintArray(int[,] arr)
//{
//    for (int i = 0; i < 4; i++)
//    {
//        for (int j = 0; j < 4; j++)
//        {
//            Console.Write(arr[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}