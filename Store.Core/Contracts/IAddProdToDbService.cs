namespace Store.Core.Services
{
    public interface IAddProdToDbService
    {
        bool AddProdToDb(string id, string pn, decimal prc, int qt);
    }
}