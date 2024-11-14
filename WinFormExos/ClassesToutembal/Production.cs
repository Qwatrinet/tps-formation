using System;
using System.Collections.Generic;
using System.Threading;

namespace ToutEnBalles.Classes
{
    public class Production
    {
        private double currentFailureRate;
        private ProdState prodState;
        private List<Crate> crates;
        private string typeProd;
        private int goal;
        private int crateProdTime;

        public delegate void ProdStateChangedEventHandler(Production prod);
        public event ProdStateChangedEventHandler prodStateChanged;

        //public delegate void CrateProducedEventHandler(Production prod,int totalCratesNb,double hourFailureRate,double totalFailureRate,int progression);
        public delegate void CrateProducedEventHandler(Production prod);
        public event CrateProducedEventHandler prodEvent;

        public string TypeProd { get => typeProd; }
        public ProdState ProdState { get => prodState; }

        public Production(string type, int goal, int crateProdTime)
        {
            this.typeProd = type;
            this.prodState = ProdState.Initialise;
            this.currentFailureRate = GenRandNumber();
            this.crates = new List<Crate>();
            this.goal = goal;
            this.crateProdTime = crateProdTime;


        }

        public Production(Production production) : this(production.typeProd, production.goal, production.crateProdTime)
        { }

        private void Produce()
        {
            while (this.prodState == ProdState.Fonctionne)
            {
                {
                    Thread.Sleep(crateProdTime);
                    CreateCrate();
                    prodEvent(this);

                }

            }

        }
        private double GenRandNumber()
        {
            return (double)new Random().Next(10000) / 10000;
        }

        public void StartProd()
        {
            Thread prodThread = new Thread(new ThreadStart(Produce));
            prodThread.Start();
            this.prodState = ProdState.Fonctionne;
            //prodStateChanged(this.prodState);
        }
        public void SuspendProd()
        {
            this.prodState = ProdState.Interrompu;
            //prodStateChanged(this.prodState);
        }

        public void CreateCrate()
        {
            if (this.prodState != ProdState.Fonctionne)
            {
                return;
            }
            bool valid = GenRandNumber() < this.currentFailureRate;
            this.crates.Add(new Crate(valid));
            EndProdIfNecessary();
        }
        public double CalcLastHourFailureRate()
        {
            DateTime lastHour = DateTime.Now.Subtract(new TimeSpan(1, 0, 0));
            List<Crate> lastHourCrates = this.crates.FindAll(c => c.ProductionDate >= lastHour);
            double failRate = lastHourCrates.Count > 0 ? (double)lastHourCrates.FindAll(c => !c.IsValid).Count / (double)lastHourCrates.Count : 0;
            return failRate;
        }
        public double CalcTotalRealFailureRate()
        {
            List<Crate> nbFail = this.crates.FindAll(c => !c.IsValid);
            double realFailRate = this.crates.Count > 0 ? (double)nbFail.Count / (double)this.crates.Count : 0;
            return realFailRate;
        }

        public int GetValidCrateNb()
        {

            return (int)Math.Round((1 - CalcTotalRealFailureRate()) * this.crates.Count, 0);

        }

        public int GetProgression()
        {
            return (int)Math.Round((double)GetValidCrateNb() / (double)this.goal * 100, 0);
        }
        private bool IsGoalMet()
        {
            if (GetValidCrateNb() >= this.goal)
            {
                return true;
            }
            return false;
        }

        private void EndProdIfNecessary()
        {
            if (!IsGoalMet())
            {
                return;
            }
            this.prodState = ProdState.Termine;
            prodStateChanged(this);
        }

    }
}
