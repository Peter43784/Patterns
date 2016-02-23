using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Singleton_ForEqualObjects()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreEqual(s1, s2);

        }
        [TestMethod]
        public void FactoryMethod_ForProperTypes()
        {
            CSharpDeveloper csDev = new CSharpDeveloper("Peter");
            Application csApp = csDev.Create();

            JavaDeveloper jDev = new JavaDeveloper("Andrey");
            JavaApplication jApp = (JavaApplication)jDev.Create();

            Assert.IsInstanceOfType(csApp, typeof(CSharpApplication));
            Assert.IsInstanceOfType(jApp, typeof(JavaApplication));
        }
        [TestMethod]
        public void AbstractFactory_ForProperTypes()
        {
            Hero elf = new Hero(new Elf());
            elf.Hit();
            elf.Move();

            Hero warior = new Hero(new Warior());
            warior.Hit();
            warior.Move();

            Assert.IsInstanceOfType(elf, typeof(Elf));
            Assert.IsInstanceOfType(warior, typeof(Warior));
        }
    }
}
