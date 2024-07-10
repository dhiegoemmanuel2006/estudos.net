using system;

Console.WriteLine("Digite o primeiro valor para soma:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o segundo valor para a soma: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");