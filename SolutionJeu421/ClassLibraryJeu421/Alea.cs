using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject421")]
namespace ClassLibraryJeu421
{
    internal class Alea : Random, INextable
    {
        private static Alea? monAlea = null;
        private Alea()
        {
        }
        public static Alea Instance()
        {
            if (monAlea == null)
            {
                monAlea = new Alea();
            }
            return monAlea;
        }
        public int Nouveau(int _valMin, int _valMax)
        {
            return base.Next(_valMin, _valMax + 1);
        }
    }
}
