namespace Naoki
{
    using Optional;

    public class Property : IProperty
    {
        private readonly string name;
        private Option<Value> value;

        public Property(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
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