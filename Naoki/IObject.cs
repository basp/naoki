namespace Naoki
{
    using System.Collections.Generic;

    public interface IObject
    {
        IProperty AddProperty(string name);

        IEnumerable<IProperty> GetProperties();
    }
}
