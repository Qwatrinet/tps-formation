using System;

namespace ToutEnBalles
{
    internal class Crate
    {
        private bool isValid;
        private DateTime productionDate;

        public Crate(bool isValid)
        {
            this.isValid = isValid;
            this.productionDate = DateTime.Now;
        }

        public bool IsValid { get => isValid; }
        public DateTime ProductionDate { get => productionDate; }
    }
}
