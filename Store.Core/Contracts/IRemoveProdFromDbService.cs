namespace Store.Core.Services
{
    public interface IRemoveProdFromDbService
    {
        bool RemoveProd(string prodId);
    }
}