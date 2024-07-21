namespace AtividadeFormação.NET.Models;

public class Estacionamento
{
    public double ValorTotal(double ValorInicial, double ValorPorHora, int HorasFicadas)
    {
        return ValorInicial + (ValorPorHora * HorasFicadas);
    }
}