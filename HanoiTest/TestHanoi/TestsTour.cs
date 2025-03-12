using ElementsHanoi;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ElementsHanoi")]
namespace TestHanoi
{
    [TestClass]
    public class TestsTour
    {
        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocInexistant_Echec()
        {
            Tour tourdepart = new Tour(new List<Bloc>());

            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(1));
            Tour tourarrivee = new Tour(blocs2);

            Assert.ThrowsException<Exception>(() => tourdepart.DeplacerBloc(tourarrivee));
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocGrosSurPetit_Echec()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(2));
            Tour tourdepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(1));
            Tour tourarrivee = new Tour(blocs2);

            Assert.ThrowsException<Exception>(() => tourdepart.DeplacerBloc(tourarrivee));
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocPetitSurGros_Reussite()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(1));
            Tour tourdepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(2));
            Tour tourarrivee = new Tour(blocs2);

            tourdepart.DeplacerBloc(tourarrivee);
            string resultDepart = tourdepart.ToString();
            string resultArrivee = tourarrivee.ToString();

            Assert.AreEqual("Tour ", resultDepart);
            Assert.AreEqual("Tour 2 1 ", resultArrivee);
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocSurTourVide_Reussite()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(2));
            Tour tourdepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            Tour tourarrivee = new Tour(blocs2);

            tourdepart.DeplacerBloc(tourarrivee);
            string resultDepart = tourdepart.ToString();
            string resultArrivee = tourarrivee.ToString();

            Assert.AreEqual("Tour ", resultDepart);
            Assert.AreEqual("Tour 2 ", resultArrivee);
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocDUneTourAvecPlusieursBlocSurTourAvecPlusieursBlocsLegalement_Reussite()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(2));
            blocs1.Add(new Bloc(1));
            Tour tourdepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(4));
            blocs2.Add(new Bloc(3));
            Tour tourarrivee = new Tour(blocs2);

            tourdepart.DeplacerBloc(tourarrivee);
            string resultDepart = tourdepart.ToString();
            string resultArrivee = tourarrivee.ToString();

            Assert.AreEqual("Tour 2 ", resultDepart);
            Assert.AreEqual("Tour 4 3 1 ", resultArrivee);
        }
    }
}