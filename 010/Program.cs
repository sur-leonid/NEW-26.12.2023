﻿//Задача 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
string s;
double N; // N также нужно задать (тут мы ему пока что присваеваем =0)
System.Console.Write("Введите N:");// предложение в терминали ввести число

s = Console.ReadLine();

N=Convert.ToDouble(s);// считывает и ковертирует введенное с терминала число N  

double LAST = N%10;//  находим  остаток от деления на 10

Console.Write("последнее цифра в числе =  ");
        System.Console.WriteLine(LAST); 