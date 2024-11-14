namespace Expressions
{
    public abstract class Binaire : Expression
    {
        protected Expression expressionGauche;
        protected Expression expressionDroite;
        public Binaire(Expression expressionGauche, Expression expressionDroite)
        {
            this.expressionGauche = expressionGauche;
            this.expressionDroite = expressionDroite;
        }

    }
}
