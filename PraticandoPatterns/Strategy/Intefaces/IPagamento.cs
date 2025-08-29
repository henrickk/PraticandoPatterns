namespace PraticandoPatterns.Strategy.Intefaces
{
    public interface IPagamento
    {
        decimal CalcularTaxa(decimal valor);
    }
}
