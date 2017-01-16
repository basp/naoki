namespace Naoki
{
    using System;

    public interface IValue
    {
        string GetString();

        int GetInt();

        decimal GetDecimal();

        DateTime GetDateTime();

        bool GetBool();
    }
}
