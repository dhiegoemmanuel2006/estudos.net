var lista1 = new int[5];

for(int contador = 0; contador < 5; contador++){
    Console.WriteLine($"Digite o valor para o elemento {contador + 1} da lista: ");
    lista1[contador] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Elementos que foram armazenados na lista:");

foreach(int num in lista1){
    Console.WriteLine(num);
}

