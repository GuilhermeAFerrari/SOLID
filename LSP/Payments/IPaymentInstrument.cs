namespace LSP.Payments;

public interface IPaymentInstrument
{
    void Validate();
    void CollectPayment();
}
