using System;

namespace Atividade_Aula_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo compra = new Calculo();

            //Nada
            System.Console.WriteLine( compra.Calcular() );
            //Uma int
            System.Console.WriteLine( compra.Calcular(10) );
            //Dois doubles
            System.Console.WriteLine( compra.Calcular(15, 1.3) );
            //Uma string
            System.Console.WriteLine( compra.Calcular("Álcool Gel") );
            //Duas strings
            System.Console.WriteLine( compra.Calcular("Álcool Gel", "Asseptgel") );
        }
    }
}
