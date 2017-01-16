namespace Naoki
{
    using Optional;

    public interface IProperty
    {
        IProperty Set(Value value);

        Option<Value> Get();
    }
}
