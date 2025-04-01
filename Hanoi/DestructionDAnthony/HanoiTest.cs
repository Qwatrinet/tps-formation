using HanoiTower;

namespace DestructionDAnthony
{
    [TestClass]
    public class HanoiTest
    {

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe5BlocsSurTourVide_Reussite()
        {
            int rings = 5;
            int[] towerOrigin = [1, 2, 3, 4, 5];
            int[] towerDestination = [0, 0, 0, 0, 0];
            int[] towerIntermediate = [0, 0, 0, 0, 0];

            Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate);

            CollectionAssert.AreEqual(new int[5] { 0, 0, 0, 0, 0 }, towerOrigin);
            Assert.IsTrue(towerIntermediate.SequenceEqual([0, 0, 0, 0, 0]));
            Assert.IsTrue(towerDestination.SequenceEqual([1, 2, 3, 4, 5]));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe2BlocsSurTourVide_Reussite()
        {
            int rings = 2;
            int[] towerOrigin = new int[2] { 1, 2 };
            int[] towerDestination = new int[2] { 0, 0 };
            int[] towerIntermediate = new int[2] { 0, 0 };

            Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate);

            Assert.IsTrue(towerOrigin.SequenceEqual([0, 0]));
            Assert.IsTrue(towerIntermediate.SequenceEqual([0, 0]));
            Assert.IsTrue(towerDestination.SequenceEqual([1, 2]));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe2BlocsSurTourVideAvecBlocInvalide_Echec()
        {
            int rings = 2;
            int[] towerOrigin = new int[2] { -1, 2 };
            int[] towerDestination = new int[2] { 0, 0 };
            int[] towerIntermediate = new int[2] { 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe5BlocsSurTourElleMeme_Echec()
        {
            int rings = 5;
            int[] towerOrigin = new int[5] { 1, 2, 3, 4, 5 };
            int[] towerDestination = towerOrigin;
            int[] towerIntermediate = new int[5] { 0, 0, 0, 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe5BlocsSurTourOuTourIntermedaireEstTourOrigin_Echec()
        {
            int rings = 5;
            int[] towerOrigin = new int[5] { 1, 2, 3, 4, 5 };
            int[] towerDestination = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerIntermediate = towerOrigin;

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUneTourDe5BlocsSurTourOuTourIntermedaireEstTourDestination_Echec()
        {
            int rings = 5;
            int[] towerOrigin = new int[5] { 1, 2, 3, 4, 5 };
            int[] towerDestination = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerIntermediate = towerDestination;

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }

        [TestMethod]
        public void Main_Hanoi_Deplacer7BlocsAlorsQueLaTourNenAQue5_Echec()
        {
            int rings = 7;
            int[] towerOrigin = new int[5] { 1, 2, 3, 4, 5 };
            int[] towerDestination = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerIntermediate = new int[5] { 0, 0, 0, 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }
        [TestMethod]
        public void Main_Hanoi_DeplacerUnNombreNegatifDeBlocs_Echec()
        {
            int rings = -4;
            int[] towerOrigin = new int[5] { 1, 2, 3, 4, 5 };
            int[] towerDestination = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerIntermediate = new int[5] { 0, 0, 0, 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));

        }
        [TestMethod]
        public void Main_Hanoi_Deplacer0BlocsSurTourVide_Reussite()
        {
            int rings = 0;
            int[] towerOrigin = new int[2] { 1, 2 };
            int[] towerDestination = new int[2] { 0, 0 };
            int[] towerIntermediate = new int[2] { 0, 0 };

            Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate);

            Assert.IsTrue(towerOrigin.SequenceEqual([1, 2]));
            Assert.IsTrue(towerIntermediate.SequenceEqual([0, 0]));
            Assert.IsTrue(towerDestination.SequenceEqual([0, 0]));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUnBlocDUneTourVide_Echec()
        {
            int rings = 1;
            int[] towerOrigin = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerDestination = new int[5] { 0, 0, 0, 0, 0 };
            int[] towerIntermediate = new int[5] { 0, 0, 0, 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));
        }
        [TestMethod]
        public void Main_Hanoi_Deplacer1BlocSurTourVide_Reussite()
        {
            int rings = 1;
            int[] towerOrigin = new int[2] { 0, 1 };
            int[] towerDestination = new int[2] { 0, 0 };
            int[] towerIntermediate = new int[2] { 0, 0 };

            Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate);

            Assert.IsTrue(towerOrigin.SequenceEqual([0, 0]));
            Assert.IsTrue(towerIntermediate.SequenceEqual([0, 0]));
            Assert.IsTrue(towerDestination.SequenceEqual([0, 1]));

        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUnBlocDUneTourSurUneTourPleine_Echec()
        {
            int rings = 2;
            int[] towerOrigin = new int[2] { 1, 2 };
            int[] towerDestination = new int[2] { 3, 4 };
            int[] towerIntermediate = new int[2] { 0, 0 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));
        }

        [TestMethod]
        public void Main_Hanoi_DeplacerUnBlocDUneTourSurUneTourVideAvecTourIntermediairePleine_Echec()
        {
            int rings = 2;
            int[] towerOrigin = new int[2] { 1, 2 };
            int[] towerDestination = new int[2] { 0, 0 };
            int[] towerIntermediate = new int[2] { 3, 4 };

            Assert.ThrowsException<ArgumentException>(() => Program.HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate));
        }
    }
}