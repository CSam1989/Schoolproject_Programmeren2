using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeustermansSamOO
{
    class Zichtrekening: Bankrekening
    {
        //attribuut
        private double _limiet;

        //Property
        public double Limiet
        {
            get { return _limiet; }
            set
            {
                if (value <= Saldo)
                {
                    _limiet = value;
                }
                else
                {
                    throw new CustomException("Limiet moet lager of gelijk zijn aan het huidig saldo!");
                }
            }
        }

        //Constructor
        public Zichtrekening(string bankrekeningnummer, double saldo, int aantalVerrichtingen, double limiet): base(bankrekeningnummer, saldo, aantalVerrichtingen)
        {
            Limiet = limiet;
        }
        public Zichtrekening(string bankrekeningnummer, double saldo = 0, double limiet = 0)
            : this(bankrekeningnummer, saldo, 0, limiet) { }

        //Methodes
        private double MaxAfTeHalenBedrag()
        { 
            return (Limiet - Saldo) * -1;
        }

        public override void AfhalenBedrag(double bedrag)
        {
                if (MaxAfTeHalenBedrag() * -1 <= bedrag * -1)
                {
                    base.AfhalenBedrag(bedrag);
                }
                else
                {
                    throw new CustomException("limiet bereikt, niet mogelijk om dit bedrag af te halen");
                }
        }

        public override string Toongegevens()
        {
            return $"{base.Toongegevens()}\nLimiet: €{Limiet.ToString("0.00")}\nMax af te halen bedrag: € {MaxAfTeHalenBedrag().ToString("0.00")}";
        }
    }
}