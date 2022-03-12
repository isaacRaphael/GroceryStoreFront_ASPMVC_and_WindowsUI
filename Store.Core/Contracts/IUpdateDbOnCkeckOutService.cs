namespace Store.Core.Services
{
    public interface IUpdateDbOnCkeckOutService
    {
        bool UpdateOnChechOut(string prodid, int qty);
    }
}