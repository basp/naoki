namespace Naoki.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Ploeh.AutoFixture;
    using System;

    [TestClass]
    public class ValueTests
    {
        [TestMethod]
        public void CreateInt()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<int>();
            var val = Value.Create(exp);

            // Act
            var act = val.GetInt();

            // Assert
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void CreateString()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<string>();
            var val = Value.Create(exp);

            // Act
            var act = val.GetString();

            // Assert
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void CreateDecimal()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<decimal>();
            var val = Value.Create(exp);

            // Act
            var act = val.GetDecimal();

            // Assert
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void CreateBool()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<bool>();
            var val = Value.Create(exp);

            // Act
            var act = val.GetBool();

            // Assert
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void CreateDateTime()
        {
            // Arrange
            var fix = new Fixture();
            var exp = fix.Create<DateTime>();
            var val = Value.Create(exp);

            // Act
            var act = val.GetDateTime();

            // Assert
            Assert.AreEqual(exp, act);
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
