using System;
using Calculadora.Services;

CalculadoraImplementacao c = new CalculadoraImplementacao();

int numero1 = 5;
int numero2 = 10;


Console.WriteLine($"{numero1} + {numero2} = {c.Somar(numero1, numero2)}"); 