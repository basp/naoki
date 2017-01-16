namespace Naoki.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Ploeh.AutoFixture;

    [TestClass]
    public class ValueTests
    {
        [TestMethod]
        public void CreateInt()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<int>();

            // Act
            var val = Value.Create(exp);
            var act = val.GetInt();

            // Assert
            Assert.AreEqual(exp, act);
            Assert.IsTrue(val.Type == Naoki.Type.Int);
        }

        [TestMethod]
        public void CreateString()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<string>();

            // Act
            var val = Value.Create(exp);
            var act = val.GetString();

            // Assert
            Assert.AreEqual(exp, act);
            Assert.IsTrue(val.Type == Naoki.Type.String);
        }

        [TestMethod]
        public void CreateDecimal()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<decimal>();

            // Act
            var val = Value.Create(exp);
            var act = val.GetDecimal();

            // Assert
            Assert.AreEqual(exp, act);
            Assert.IsTrue(val.Type == Naoki.Type.Decimal);
        }

        [TestMethod]
        public void CreateBool()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<bool>();

            // Act
            var val = Value.Create(exp);
            var act = val.GetBool();

            // Assert
            Assert.AreEqual(exp, act);
            Assert.IsTrue(val.Type == Naoki.Type.Bool);
        }

        [TestMethod]
        public void CreateDateTime()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<DateTime>();

            // Act
            var val = Value.Create(exp);
            var act = val.GetDateTime();

            // Assert
            Assert.AreEqual(exp, act);
            Assert.IsTrue(val.Type == Naoki.Type.DateTime);
        }

        [TestMethod]
        public void CreateObject()
        {
        }

        [TestMethod]
        public void CreateList()
        {
        }
    }
}
