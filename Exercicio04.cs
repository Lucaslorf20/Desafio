using System;

/*
SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53
*/

class Program {
  public static void Main (string[] args) {
    double vlSP = 67836.43;
    double vlRJ = 36678.66;
    double vlMG = 29229.88;
    double vlES = 27165.48;
    double vlXX = 19849.53;
    double vlTotal = vlSP + vlRJ + vlMG + vlES + vlXX;

    Console.WriteLine("Percentual de SP: {0}%", (vlSP / vlTotal * 100).ToString("N2"));
    Console.WriteLine("Percentual de RJ: {0}%", (vlRJ / vlTotal * 100).ToString("N2"));
    Console.WriteLine("Percentual de MG: {0}%", (vlMG / vlTotal * 100).ToString("N2"));
    Console.WriteLine("Percentual de ES: {0}%", (vlES / vlTotal * 100).ToString("N2"));
    Console.WriteLine("Percentual de Outros: {0}%", (vlXX / vlTotal * 100).ToString("N2"));
  }
}