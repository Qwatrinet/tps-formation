namespace ToutEnBalles
{
    public class Crate
    {
        private CrateType type;
        private bool isValid;

        public Crate(CrateType type, bool isValid)
        {
            this.type = type;
            this.isValid = isValid;
        }

        public CrateType Type { get => type; }
        public bool IsValid { get => isValid; }
    }
}
