﻿using System.Reflection;

class Program
{
    static void Main()
    {
        Thread t = new Thread(new ThreadStart(MethodA));
        t.Start();
        MethodB();
    }
    static void MethodA()
    {
        for (int i = 0; i < 100; i++) { 
        Console.WriteLine("0");}

    }
    static void MethodB()
    {
        for(int i = 0;i < 100;i++) {
        Console.WriteLine("1");}
    }
}
