﻿// Задача 8. Вывести на экран числа от -N до N
//int i=1;  // 1 -это число
           //
int N=0; // N задаtv (тут мы ему пока что присваеваем =0)

System.Console.Write("Введите N:");
N=Convert.ToInt32(Console.ReadLine());// эта строка будет считывать заданное нами значение N "вводом с терминала"
int M = -N; // т.к. после int мы не можем стваить "-"  то опишем -N  ( как М кторое =  -N)//нц пока i<=N
int i=-N; 
 Console.WriteLine("список чисел : ");
while (i <= N & i >= M)
    {
        Console.Write("число ");
        System.Console.WriteLine(i);   // процес прибавления 2+2+2+2+2+ пока не настанет N
        i=i+1;
    }
    //кц