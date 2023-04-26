// Задайте массив из 12 элементов от -9 до 9.
// Найдите сумму отрицательных и положительных элементов массива.
// Нпример в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6], сумма положительных чисел равна 29, сумма отрицательных -20

// int[] numArr = new int[12];
// int posNum = 0;
// int negNum = 0;

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(-9, 9);
//     if (numArr[i] > 0)
//     {
//         posNum = numArr[i] + posNum;
//     }
//     else
//     {
//         negNum = numArr[i] + negNum;
//     }
// }
// Console.WriteLine(String.Join(",", numArr) + "\nсумма положительных" + posNum + "отрицательных" + negNum);


// Задача №2
// Написать программу, замена элементов массива: положительные элементы заменить на соответсвующие отрицательные
// {-4,-8,2,1}  {4,8,-2,-1}

// int[] numArr = new int[] { 1, -600, 500, 25, -1 };
// Console.WriteLine(String.Join(",", numArr));

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = numArr[i] * -1;
// }

// Console.WriteLine(String.Join(",", numArr));

//Задача №3
// Задайте массив. Напишите, программу которая определяет присутсвуте ли данное число в массиве или нет
// 4; массив {6,7,9,20,3,1}----> нет

// Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] numArr = new int[] { 1, -600, 500, 25, -1 };
// Console.WriteLine(String.Join(",", numArr));

// bool flag = false;

// for (int i = 0; i < numArr.Length; i++)
// {
//     if (numArr[i] == num)
//     {
//         flag = true;
//     }
// }
// if (flag == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Задача №4
// Задайте одномерный массив состоящий из 123 случайных чисел.
// Найдите кол-во элементов массива которые лежат в отрезке [10,99]
// Для дпнног решения работать с массивом из 5 цифр
// [10,11,12,13,9] ----> 4

// int[] numArr = new int[5];

// int num = 0;

// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 501);
//     if ((numArr[i] >= 10) && (numArr[i] < 100))
//     {
//         num = num + 1;
//     }
// }
// Console.WriteLine(String.Join(",", numArr));
// Console.WriteLine("Кол-во двухзначных чисел = " + num);