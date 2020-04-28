using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeustermansSamOO
{
    class Bankrekening:object
    {
        //Properties
        public string Bankrekeningnummer { get; }
        public double Saldo { get; protected set; }
        public int AantalVerrichtingen { get; protected set; }

        //Constructor 
        protected Bankrekening(string bankrekeningnummer, double saldo = 0) : this(bankrekeningnummer, saldo, 0) { }
        protected Bankrekening(string bankrekeningnummer, double saldo, int aantalVerrichtingen)
        { 
            Bankrekeningnummer = bankrekeningnummer;
            Saldo = saldo;
            AantalVerrichtingen = aantalVerrichtingen;
        }

        //Methodes
        public virtual string Toongegevens()//label
        {
            return "Bankrekeningnummer: " + Bankrekeningnummer.ToUpper() + Environment.NewLine +
                "Aantal verrichtingen: " + AantalVerrichtingen + Environment.NewLine +
                "Saldo: €" + Saldo.ToString("0.00");
        }

        public override string ToString()//combobox
        {
            return Bankrekeningnummer + ": € " + Saldo.ToString("0.00");
        } 

        public void StortBedrag(double bedrag)
        {
            AantalVerrichtingen++;

            if (bedrag > 0)
            {
                Saldo += bedrag;
            }
            else
            {
                throw new CustomException("Negatief bedrag storten is niet mogelijk");
            }
        }

        public virtual void AfhalenBedrag(double bedrag)
        {
            AantalVerrichtingen++;

            if (bedrag > 0)
            {
                    Saldo -= bedrag;
            }
            else
            {
                throw new CustomException("Negatief bedrag afhalen is niet mogelijk");
            }
        }

        public override bool Equals(object obj)
        {
            Bankrekening b = obj as Bankrekening;
            return b != null && b.Bankrekeningnummer == this.Bankrekeningnummer;
        }
    }
}