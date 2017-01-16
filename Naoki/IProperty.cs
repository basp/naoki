namespace Naoki
{
    public interface IProperty
    {
        IProperty Set(Value value);

        Value Get();
    }
}
