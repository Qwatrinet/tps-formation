namespace Expressions
{
    public class Addition : Binaire
    {
        public Addition(Expression expressionGauche, Expression expressionDroite) : base(expressionGauche, expressionDroite) { }

        public override int EvalueToi()
        {
            return expressionGauche.EvalueToi() + expressionDroite.EvalueToi();
        }

        public override string Display()
        {
            return expressionGauche.Display() + "+" + expressionDroite.Display();
        }
        public override string Formate()
        {
            return this.Display() + "=" + this.EvalueToi();
        }

    }
}
