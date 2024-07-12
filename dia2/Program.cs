using System.Diagnostics;
using Calculadora;

Calculadora.OPS calculadora = new Calculadora.OPS();
int Operation = 1;


while(Operation != 0) {
    Console.WriteLine("\tCALCULADORA\t");
    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRACAO");
    Console.WriteLine("3 - MULTIPLICACAO");
    Console.WriteLine("4 - DIVISAO");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("DIGITE ABAIXO A OPERACAO QUE DESEJA: ");
    Operation = Convert.ToInt32(Console.ReadLine());

double num1;
double num2;
double resultado = 0;
    switch(Operation){
        case 1:
            Console.WriteLine("Digite o primeiro valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = calculadora.soma(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {resultado}");
            break;
        case 2:
           Console.WriteLine("Digite o primeiro valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = calculadora.subtracao(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {resultado}");
            break;
        case 3:
            Console.WriteLine("Digite o primeiro valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = calculadora.multiplicacao(num1, num2);
            Console.WriteLine($"{num1} x {num2} = {resultado}");
            break;
        case 4:
            Console.WriteLine("Digite o primeiro valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = calculadora.divisao(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {resultado}");
            break;
        case 0:
            Console.WriteLine("Esperto ter ajudado!");
            break;
        default:
            Console.WriteLine("Digite um dos valores citados!");

    }
}