using System;
using System.Collections.Generic;

namespace ToutEnBalles.Classes
{
    public class Production
    {
        private double currentFailureRate;
        private bool isRunning;
        private List<Crate> crates;
        private CrateType typeProd;
        private int prodRate;
        private int time;//temps écoulé de production en s

        public Production(CrateType type, int prodRate)
        {
            this.typeProd = type;
            this.isRunning = false;
            this.currentFailureRate = GenRandNumber();
            this.crates = new List<Crate>();
            this.prodRate = prodRate;
            this.time = 0;
        }

        private double GenRandNumber()
        {
            double r = new Random(10000).Next() / 10000;
            return Math.Round(r, 4);
        }

        public void GenNewFailureRate()
        {
            this.currentFailureRate = GenRandNumber();
        }
        public void StartProd()
        {
            this.isRunning = true;
        }
        public void StopProd()
        {
            this.isRunning = false;
        }
        public void CreateCrate()
        {
            bool valid = GenRandNumber() < this.currentFailureRate;
            this.crates.Add(new Crate(this.typeProd, valid));
        }

        public double CalcTotalRealFailureRate()
        {
            List<Crate> nbFail = this.crates.FindAll(c => !c.IsValid);
            double realFailRate = nbFail.Count / this.crates.Count;
            return Math.Round(realFailRate, 4);
        }

    }
}
