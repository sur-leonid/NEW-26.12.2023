﻿// Задача 9. Вывести на экран четные числа от 1 до N
int i=2;  // 2 -это первре четное число после 1 
           //а прибавляя к нему 2 мы будемполучать все последующие четные числа
int N=0; // N также нужно задать (тут мы ему пока что присваеваем =0)

System.Console.Write("Введите N:");
N=Convert.ToInt32(Console.ReadLine());// эта строка будет считывать заданное нами значение N "вводом с терминала"
//нц пока i<=N
 Console.WriteLine("список четных чисел : ");
    while (i<=N)
    {
        Console.Write("четное число ");
        System.Console.WriteLine(i);   // процес прибавления 2+2+2+2+2+ пока не настанет N
        i=i+2;
    }
    //кц