using dia4.models;

int opcao = 0;

Curso Aluno = new Curso();

do
{
    Console.WriteLine("\tBem vindo ao sistema do curso\t");
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Remover cadastro do auno");
    Console.WriteLine("3 - Lista alunos");
    Console.WriteLine("4 - Quantidade de alunos matriculados");
    Console.WriteLine("5 - Encerrar programa");
    Console.WriteLine("Qual operação deseja: ");
    opcao = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Digite qualquer tecla para seguir");
    Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Aluno.AlunoSet();
            break;
        case 2: 
            Aluno.RemoverAluno();
            break;
        case 3:
            Aluno.ListarAlunos();
            break;
        case 4:
            Aluno.QuantidadeAlunos();
            break;
        case 5:
            Console.WriteLine("Programa encerrado!");
            break;
    }
} while (opcao != 5);