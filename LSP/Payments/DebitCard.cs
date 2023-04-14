namespace LSP.Payments;

public class DebitCard : NubankCard
{
    public override void Validate()
    {
        Console.WriteLine("Verificar o saldo da conta...");
        Console.WriteLine("Saldo disponível.");
    }
}
