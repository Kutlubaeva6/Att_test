﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array elements separated by commas: ")
            string[] inputArray = input.Splint(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            string[] resultArray = FilterStr(inputArray);
            Console.WriteLine("Ready array: ")

        } 



        static string[] FilterStr(string[] inputArray)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <=3)
                {
                    count++
                }
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        fot (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i.Length <= 3])
            {
                resultArray[index] = inputArray[i]
                index++
            }
        }
        
        return resultArray


    }