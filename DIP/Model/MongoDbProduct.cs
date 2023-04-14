namespace DIP.Model;

public class MongoDbProduct : IDbProduct
{
    public string GetProductById(string id)
    {
        return $"MongoDB: Exibindo dados do produto {id}";
    }
}
