namespace LSP.Payments;

public abstract class NubankCard : IPaymentInstrument
{
    public void CollectPayment()
    {
        Console.WriteLine("Pagamento realizado!");
    }

    public virtual void Validate()
    {
        //Validação básica
    }
}
