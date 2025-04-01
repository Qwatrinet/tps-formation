using ClassLibraryJeu421;
using Moq;


namespace TestProject421
{

    [TestClass]
    public class UnitTestRound
    {
        [TestMethod]
        public void TestMethod()
        {
            Mock<INextable> fakeAlea = new Mock<INextable>();
            fakeAlea.SetupSequence(a => a.Nouveau(1, 6)).Returns(4).Returns(2).Returns(1);

            De de1 = new De(6);
            De de2 = new De(6);
            De de3 = new De(6);

            Assert.AreEqual(4, fakeAlea.Object.Nouveau(1, 6));
            Assert.AreEqual(2, fakeAlea.Object.Nouveau(1, 6));
            Assert.AreEqual(1, fakeAlea.Object.Nouveau(1, 6));

        }
    }
}