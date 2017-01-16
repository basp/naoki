namespace Naoki
{
    public interface IRepository
    {
        IKey Create();

        IObject Get(IKey key);

        void Save(IObject obj);
    }
}
