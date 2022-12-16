using System;

namespace SubProdutoSomaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1; 
            int s = 0;
            while (n > 0){
              int l = n % 10;
             // TODO: Crie as outras condições necessárias para a resolução do desafio:
              p *= l;
              s += l;
              n = n/10;
           }
            
            Console.WriteLine(p-s);
            
        }
    }
}
