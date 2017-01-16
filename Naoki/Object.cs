namespace Naoki
{
    using System.Collections.Generic;

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

        public IProperty AddProperty(string name, Type type)
        {
            var prop = new Property(name, type);
            this.properties.Add(name, prop);
            return prop;
        }
    }
}
