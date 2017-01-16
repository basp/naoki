namespace Naoki
{
    using System;
    using System.Collections.Generic;

    public struct Value : IValue
    {
        private readonly Type type;

        private readonly int i;
        private readonly decimal d;
        private readonly bool b;
        private readonly DateTime dt;
        private readonly string s;
        private readonly IObjectId obj;
        private readonly IList<IValue> list;

        private Value(Type type)
        {
            this.type = type;
            this.i = 0;
            this.d = 0;
            this.b = false;
            this.dt = DateTime.MinValue;
            this.s = string.Empty;
            this.obj = null;
            this.list = new List<IValue>();
        }

        private Value(int i)
            : this(Type.Int)
        {
            this.i = i;
        }

        private Value(decimal d)
            : this(Type.Decimal)
        {
            this.d = d;
        }

        private Value(bool b)
            : this(Type.Bool)
        {
            this.b = b;
        }

        private Value(DateTime dt)
            : this(Type.DateTime)
        {
            this.dt = dt;
        }

        private Value(string s)
            : this(Type.String)
        {
            this.s = s;
        }

        private Value(IObjectId obj)
            : this(Type.Object)
        {
            this.obj = obj;
        }

        private Value(IList<IValue> list)
            : this(Type.List)
        {
            this.list = list;
        }

        public static Value Create(int val)
        {
            return new Value(val);
        }

        public static Value Create(string val)
        {
            return new Value(val);
        }

        public static Value Create(decimal val)
        {
            return new Value(val);
        }

        public static Value Create(DateTime val)
        {
            return new Value(val);
        }

        public static Value Create(bool val)
        {
            return new Value(val);
        }

        public static Value Create(IObjectId val)
        {
            return new Value(val);
        }

        public static Value Create(IList<IValue> val)
        {
            return new Value(val);
        }

        public string GetString()
        {
            return this.s;
        }

        public int GetInt()
        {
            return this.i;
        }

        public decimal GetDecimal()
        {
            return this.d;
        }

        public DateTime GetDateTime()
        {
            return this.dt;
        }

        public bool GetBool()
        {
            return this.b;
        }

        public IObjectId GetObject()
        {
            return this.obj;
        }

        public IList<IValue> GetList()
        {
            return this.list;
        }
    }
}
