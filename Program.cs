/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

using System;
using static System.Console;

Clear();

//Запрос массива
WriteLine("Введите элементы массива (через запятую и следом один пробел): ");
string[] writingArray = ReadLine()!.Split(", ");
string[] newArray = new string[writingArray.Length];

//Проверка на количество символов в элементе
int index = 0;
for (int i = 0; i < writingArray.Length; i++)
{
    if (writingArray[i].Length <= 3)
    {
        newArray[index] = writingArray[i];
        index++;
    }
}

//Запись элементов в новый массив
string[] finalArray = new string[index];
Array.Copy(newArray, finalArray, index);

//Вывод результата
WriteLine("Результат:");
foreach (string element in finalArray)
    Write(element + ", ");