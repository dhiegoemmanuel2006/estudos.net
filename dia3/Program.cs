using dia3.models;

public class main
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Dhiego";
        p1.Sobrenome = "Emmanuel";
        p1.Idade = 18;
        
        p1.Apresentar();
    }
}