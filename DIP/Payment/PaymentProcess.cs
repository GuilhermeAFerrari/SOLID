using DIP.Factory;
using DIP.Model;

namespace DIP.Payment;

public class PaymentProcess
{
    public void Pay(string id)
    {
        IDbProduct product = DbProductFactory.Create();
        var productData = product.GetProductById(id);
        Console.WriteLine(productData);
    }
}
