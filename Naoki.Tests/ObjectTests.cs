namespace Naoki.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Naoki;
    using Ploeh.AutoFixture;
    using System.Linq;

    [TestClass]
    public class ObjectTests
    {
        [TestMethod]
        public void Create()
        {
            // Act
            var root = Object.Create();

            // Assert
            Assert.IsInstanceOfType(root, typeof(IObject));
        }

        [TestMethod]
        public void AddProperty()
        {
            // Arrange
            var fix = new Fixture();
            var value = Value.Create(fix.Create<string>());
            var root = Object.Create();

            // Act
            var prop = root
                .AddProperty("frotz")
                .Set(value);

            // Assert
            prop.Get().MatchSome(
                x => Assert.AreEqual(value.GetString(), x.GetString()));

            prop.Get().MatchNone(() => Assert.Fail());
        }

        [TestMethod]
        public void GetProperties()
        {
            // Arrange
            var fix = new Fixture();
            var val1 = fix.Create<string>();
            var val2 = fix.Create<int>();
            var root = Object.Create();

            root.AddProperty("foo").Set(Value.Create(val1));
            root.AddProperty("bar").Set(Value.Create(val2));
            root.AddProperty("baz");

            // Act
            var props = root.GetProperties();
            var foo = props.First(x => x.Name.Equals("foo"));
            var bar = props.First(x => x.Name.Equals("bar"));
            var baz = props.First(x => x.Name.Equals("baz"));

            // Assert
            foo.Get().MatchSome(x => Assert.AreEqual(val1, x.GetString()));
            foo.Get().MatchNone(() => Assert.Fail());
            bar.Get().MatchSome(x => Assert.AreEqual(val2, x.GetInt()));
            bar.Get().MatchNone(() => Assert.Fail());
            baz.Get().MatchSome(x => Assert.Fail());
        }
    }
}
