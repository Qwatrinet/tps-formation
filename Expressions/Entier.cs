namespace Expressions
{
    public class Entier : Expression
    {
        private int valeur;

        public Entier(int valeur)
        {
            this.valeur = valeur;
        }

        public override int EvalueToi()
        {
            return this.valeur;
        }

        public override string Display()
        {
            return this.valeur.ToString();
        }

        public override string Formate()
        {
            return this.Display() + "=" + this.EvalueToi();
        }

    }
}
