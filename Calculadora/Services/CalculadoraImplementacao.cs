using System;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {

        public int Somar(int numero1, int numero2)
        {

            return numero1 + numero2;

        }

        public bool  VerificarSeNumeroEPar(int numero)
        {

            return numero % 2 == 0;

        }


    }
}
