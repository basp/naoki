namespace Naoki
{
    using System;
    using System.Collections.Generic;

    public struct Value
    {
        private readonly Type type;

        private readonly int i;
        private readonly decimal d;
        private readonly bool b;
        private readonly DateTime dt;
        private readonly string s;
        private readonly IList<Value> list;

        private Value(Type type)
        {
            this.type = type;
            this.i = 0;
            this.d = 0;
            this.b = false;
            this.dt = DateTime.MinValue;
            this.s = null;
            this.list = null;
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
    }
}
