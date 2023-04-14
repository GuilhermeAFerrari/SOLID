namespace LSP.Payments;

public class NubankRewards : IPaymentInstrument
{
    public void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado com sucesso");
        Console.WriteLine("Pontuação creditada no programa rewards");
    }

    public void Validate()
    {
        Console.WriteLine("Limite OK, Rewards OK");
    }
}
