using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeustermansSamOO
{
    class Spaarrekening: Bankrekening
    {
        //Attributen
        private double _rente;

        //Properties
        public double Rente
        {
            get { return _rente; }
            set
            {   //rente moet groter of gelijk aan 1 zijn
                if (value >= 1)
                {
                    _rente = value;
                }
                else
                {
                    throw new CustomException("Rente kan niet lager als 1% zijn!");
                }
            }
        }

        //Constructor
        public Spaarrekening(string bankrekeningnummer, double saldo, int aantalVerrichtingen, double rente)
            : base(bankrekeningnummer, saldo, aantalVerrichtingen) {
            Rente = rente;
        }
        public Spaarrekening(string bankrekeningnummer, double saldo = 0, double rente = 1) :this(bankrekeningnummer,saldo,0,rente) { }

        //Methodes
        public void RenteBijtellen()
        {
            if (AantalVerrichtingen % 10 == 0) //ipv per jaar rente te geven
            {
                Saldo *= (1 + (Rente / 100));
            }
        }

        public override string Toongegevens()
        {
            return $"{base.Toongegevens()}\nRente: {Rente.ToString("0.0")}%";
        }
    }
}
