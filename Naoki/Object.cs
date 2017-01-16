using System;

namespace Naoki
{
    public class Object : IObject
    {
        private Object()
        {
        }

        public static IObject Create()
        {
            return new Object();
        }


        IProperty IObject.AddProperty(string v, Type @string)
        {
            throw new NotImplementedException();
        }
    }
}
