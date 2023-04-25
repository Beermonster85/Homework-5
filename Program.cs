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