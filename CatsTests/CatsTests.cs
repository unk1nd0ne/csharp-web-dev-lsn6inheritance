using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;

namespace CatsTests
{
    [TestClass]
    public class CatsTests
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            // <insert assertion method here>
            Assert.AreEqual(13, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void IsNotInitiallyTired()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.IsFalse(keyboardCat.Hungry);
            Assert.IsFalse(keyboardCat.Tired);
            keyboardCat.Eat();
            Assert.IsTrue(keyboardCat.Tired);
        }
    }
}
