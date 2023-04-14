using DIP.Model;

namespace DIP.Factory;

public static class DbProductFactory
{
    public static IDbProduct Create()
    {
        if (Config.Database == "SQLSERVER")
        {
            return new SQLServerProduct();
        }
        else if (Config.Database == "MONGODB")
        {
            return new MongoDbProduct();
        }
        else
        {
            throw new NotImplementedException("Database without configuration");
        }
    }
}
