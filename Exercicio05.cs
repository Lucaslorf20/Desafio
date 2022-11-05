using System;

class Program {
  public static void Main (string[] args) {
    string palavra = "";
    Console.WriteLine("Digite uma palavra: ");
    palavra = Console.ReadLine();

    char[] cArray = palavra.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    Console.WriteLine(reverse);
  }
}