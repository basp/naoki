namespace Naoki
{
    using Optional;

    public class Property : IProperty
    {
        private readonly string name;
        private Type type;
        private Option<Value> value;

        public Property(string name, Type type)
        {
            this.name = name;
            this.type = type;
        }

        public Option<Value> Get()
        {
            return this.value;
        }

        public IProperty Set(Value value)
        {
            this.value = Option.Some(value);
            return this;
        }
    }
}