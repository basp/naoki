namespace Naoki
{
    using System;
    using System.Collections.Generic;

    public interface IValue
    {
        Type Type { get; }

        string GetString();

        int GetInt();

        decimal GetDecimal();

        DateTime GetDateTime();

        bool GetBool();

        IList<IValue> GetList();

        IKey GetObject();
    }
}
