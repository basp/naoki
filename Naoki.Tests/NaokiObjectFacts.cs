namespace Naoki.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Naoki;

    [TestClass]
    public class NaokiObjectFacts
    {
        [TestMethod]
        public void CreateObjects()
        {
            var root = Naoki.Object.Create();
            Assert.IsInstanceOfType(root, typeof(IObject));
        }

        [TestMethod]
        public void AddProperty()
        {
            var value = Value.Create("frotz");
            var root = Naoki.Object.Create();
            var prop = root
                .AddProperty("frotz", Naoki.Type.String)
                .Set(value);

            var act = prop.Get();
            Assert.AreEqual("quux", act);
        }
    }
}
