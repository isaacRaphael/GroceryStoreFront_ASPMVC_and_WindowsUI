namespace Store.Core
{
    public interface IStoreStaff
    {
        void RemoveFromProduct(string id, int numberChange);
        Product GetProduct(string id);
    }
}