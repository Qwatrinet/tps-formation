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
            Tour tourDepart = new Tour(new List<Bloc>());
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(1));
            Tour tourarrivee = new Tour(blocs2);

            Assert.ThrowsException<Exception>(() => tourDepart.DeplacerBloc(tourarrivee));
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocGrosSurPetit_Echec()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(2));
            Tour tourDepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(1));
            Tour tourarrivee = new Tour(blocs2);

            Assert.ThrowsException<Exception>(() => tourDepart.DeplacerBloc(tourarrivee));
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocPetitSurGros_Reussite()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(1));
            Tour tourDepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            blocs2.Add(new Bloc(2));
            Tour tourarrivee = new Tour(blocs2);

            tourDepart.DeplacerBloc(tourarrivee);
            string resultDepart = tourDepart.ToString();
            string resultArrivee = tourarrivee.ToString();

            Assert.AreEqual("Tour ", resultDepart);
            Assert.AreEqual("Tour 2 1 ", resultArrivee);
        }

        [TestMethod]
        public void Tour_DeplacerBloc_DeplacerBlocSurTourVide_Reussite()
        {
            List<Bloc> blocs1 = new List<Bloc>();
            blocs1.Add(new Bloc(2));
            Tour tourDepart = new Tour(blocs1);
            List<Bloc> blocs2 = new List<Bloc>();
            Tour tourarrivee = new Tour(blocs2);

            tourDepart.DeplacerBloc(tourarrivee);
            string resultDepart = tourDepart.ToString();
            string resultArrivee = tourarrivee.ToString();

            Assert.AreEqual("Tour ", resultDepart);
            Assert.AreEqual("Tour 2 ", resultArrivee);
        }

    }
}