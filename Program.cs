using System;

namespace Exercicio_com_laco_for
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Deseja ver a tabuada de qual número?");
           int resposta = int.Parse(Console.ReadLine());

           int resultado;

           for (int contador = 0; contador <= 10; contador++)
           {
               //código a se repetir
                resultado = resposta * contador;

               Console.WriteLine($"{resposta} x {contador} = {resultado}");
               
           }
        }
    }
}
