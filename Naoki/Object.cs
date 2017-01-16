namespace Naoki
{
    using System.Collections.Generic;
    using Optional;

    public class Object : IObject
    {
        private readonly IDictionary<string, IProperty> properties =
            new Dictionary<string, IProperty>();

        private Object()
        {
        }

        public static IObject Create()
        {
            return new Object();
        }

        public IProperty AddProperty(string name)
        {
            var prop = new Property(name);
            this.properties.Add(name, prop);
            return prop;
        }

        public Option<IProperty> RemoveProperty(string name)
        {
            if (!this.properties.ContainsKey(name))
            {
                return Option.None<IProperty>();
            }

            var prop = this.properties[name];
            this.properties.Remove(name);
            return Option.Some(prop);
        }

        public IEnumerable<IProperty> GetProperties()
        {
            return this.properties.Values;
        }
    }
}
