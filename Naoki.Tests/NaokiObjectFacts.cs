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
            var value = Value.Create("quux");
            var root = Naoki.Object.Create();
            var prop = root
                .AddProperty("frotz", Naoki.Type.String)
                .Set(value);

            prop.Get().MatchSome(x => Assert.AreEqual("quux", x.GetString()));
            prop.Get().MatchNone(() => Assert.Fail());
        }
    }
}
