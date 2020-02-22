using Lab3Depart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Tests
{
    [TestClass]
    public class UnitTest1
    {
        IEnumerable<Fruit> fruits;
        LinqExo le;

        [TestInitialize]
        public void StartUp()
        {
            le = new LinqExo();

            fruits = new List<Fruit>()
            {
                new Fruit() { Nom = "Abricot"}, new Fruit() { Nom = "Banane"}, new Fruit() { Nom = "Cerise"}, new Fruit() { Nom = "Datte"},
            };
        }
        
        [TestMethod]
        public void TestContientA()
        {
            var reponse = le.ContientA(fruits);
            Assert.AreEqual(reponse.Count(), 3);
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(0)));
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(1)));
            Assert.IsTrue(reponse.Contains(fruits.ElementAt(3)));
        }

        [TestMethod]
        public void TestContientAVide()
        {
            Assert.AreEqual(le.ContientA(new List<Fruit>(){ new Fruit() { Nom = "Cerise" }}).Count(), 0);
            Assert.AreEqual(le.ContientA(new List<Fruit>()).Count(), 0);
        }
    }
}
