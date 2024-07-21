using System;
using AtividadeFormação.NET.Models;

class Program
{
    static void Main(string[] args)
    {
        // Separando as variaveis que irei ultilizar durante o programa.
        double ValorInicial;
        double ValorPorHora;
        double resultado;
        int HorasFicadas;
        int Opcao = 0;
        List<string> VeiculosEstacionados = new List<string>();
        string placa;
        Estacionamento valor = new Estacionamento();
        
        // Inicio do programa e denominacao dos valores do estacionamento
        Console.WriteLine("Bem vindo ao sistema de estacionamento!");
        Console.WriteLine("Digite o valor inicial do estacionamento: ");
        ValorInicial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Agora digite o valor por hora: ");
        ValorPorHora = Convert.ToDouble(Console.ReadLine());
        
        Console.Clear();
        
        //Switch para exercer a escolha do usuario e o programa em si
        do
        {
            Console.WriteLine("Digite a sua opcao: ");
            Console.WriteLine("1\t-\tCadastrar veiculo");
            Console.WriteLine("2\t-\tRemover veiculo");
            Console.WriteLine("3\t-\tListar veiculos");
            Console.WriteLine("4\t-\tEncerrar");
            Opcao = Convert.ToInt32(Console.ReadLine());

            switch (Opcao) 
            {
                case 1:
                    Console.WriteLine("Digite a placa do veiculo: ");
                    placa = Console.ReadLine();
                    VeiculosEstacionados.Add(placa);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Digite a placa que removera: ");
                    placa = Console.ReadLine();
                    VeiculosEstacionados.Remove(placa);
                    Console.WriteLine("Horas que o veiculo permaneceu estacionado: ");
                    HorasFicadas = Convert.ToInt32(Console.ReadLine());
                    resultado = valor.ValorTotal(ValorInicial, ValorPorHora, HorasFicadas);
                    Console.WriteLine($"O carro da placa {placa} devera pagar o total de R${resultado}");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    foreach (var veiculo in VeiculosEstacionados)
                    {
                        Console.WriteLine(veiculo);
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Programa se encerrou!");
                    break;
            }
        
        } while (Opcao != 4);

    }
}