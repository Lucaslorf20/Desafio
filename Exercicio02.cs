using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int n=0;
    List<int> Fibonacci = new List<int>();
    Console.WriteLine("Digite um número: ");
    n = int.Parse(Console.ReadLine());
  
    for (int i=0; i<=10; i++) 
    {
      Fibonacci.Add(Fibro(i + 1));
    }
    if(Fibonacci.Contains(n))
    {
      Console.WriteLine("{0} pertence a sequencia de Fibonacci", n);
    }
    else
    {
      Console.WriteLine("{0} não pertence a sequencia de Fibonacci", n);
    }
  }

  public static int Fibro(int n)
  {
      if (n == 1 || n == 0)
      {
        return 1;
      }
      else 
      {
        return Fibro(n - 1) + Fibro(n - 2);//recursivo 
      }
  }
}