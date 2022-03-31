namespace Store.Core
{
    public interface IStore : IStoreManager, IStoreStaff
    {
        User User { get; set; }
    }
}