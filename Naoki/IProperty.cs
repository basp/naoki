namespace Naoki
{
    using Optional;

    public interface IProperty
    {
        string Name { get; }

        IProperty Set(Value value);

        Option<Value> Get();
    }
}
