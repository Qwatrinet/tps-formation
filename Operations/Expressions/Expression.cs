namespace Expressions
{
    public abstract class Expression
    {
        public abstract string Display();
        public string Formate()
        {
            return this.Display() + "=" + this.EvalueToi();
        }
        public abstract int EvalueToi();
    }
}
