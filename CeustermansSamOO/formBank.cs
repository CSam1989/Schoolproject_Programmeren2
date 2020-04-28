using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeustermansSamOO
{
    public partial class formBank : Form
    {
        List<Bankrekening> rekeningen = new List<Bankrekening>();

        public formBank()
        {
            InitializeComponent();
        }

        private void ToonOfVerbergFormulierElementen(bool tonen=true, int hoogte=574)
        {
            this.Size = new Size(432, hoogte);
            panelToonVerberg.Hide();

            if (tonen)
            {
                panelToonVerberg.Show();
            }
        }

        private bool ControleerValuta(string tekst, out double valuta, string foutboodschap, bool optioneelVeld = true)
        {
            valuta = 0;

            if (optioneelVeld)
            {
                if (tekst is null || !double.TryParse(tekst, out valuta))
                {
                    MessageBox.Show(foutboodschap, "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return true;
            }

            if (double.TryParse(tekst, out valuta))
            {
                return true;
            }
            MessageBox.Show(foutboodschap, "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void StortOfAfhalenBedrag(bool storten = true)
        {
            int index = comboBoxRekeningen.SelectedIndex;

            if (ControleerValuta(textBoxBedrag.Text, out double bedrag, "Foutief of geen bedrag opgegeven, geef een juiste valuta op", false))
            {
                try
                {
                    if (storten)
                    {
                        rekeningen[index].StortBedrag(bedrag);
                    }
                    else
                    {
                        rekeningen[index].AfhalenBedrag(bedrag);
                    }

                    if (rekeningen[index] is Spaarrekening s)
                    {
                        s.RenteBijtellen();
                    }

                    LijstUpdaten(rekeningen[index], index);
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            textBoxBedrag.Clear();
        }

        private void UpdatenCombobox()
        {
            comboBoxRekeningen.DataSource = null;
            comboBoxRekeningen.DataSource = rekeningen;
        }

        private bool ControleerDubbelRekeningnummer(Bankrekening r)
        {
            if (rekeningen.Contains(r))
            {
                return true;
            }
            return false;
        }

        private void LijstUpdaten(Bankrekening b, int index)
        {
            rekeningen.RemoveAt(index); //lijst met objecten updaten
            rekeningen.Insert(index, b);

            labelOverzicht.Text = b.Toongegevens(); 
        }

        private void formBank_Load(object sender, EventArgs e)
        {
            Bankrekening b;

            using (StreamReader teLezenBestand = new StreamReader("bankrekening.txt"))
            {
                while (!teLezenBestand.EndOfStream)
                {
                    string lijn = teLezenBestand.ReadLine();

                    if (!string.IsNullOrEmpty(lijn))
                    {
                        string[] record = lijn.Split(';');

                        if (record[0].Substring(0,1) == "Z")
                        {
                            b = new Zichtrekening(record[0].Trim(), double.Parse(record[1].Trim()), int.Parse(record[2].Trim()), double.Parse(record[3].Trim()));
                        }
                        else
                        {
                            b = new Spaarrekening(record[0].Trim(), double.Parse(record[1].Trim()), int.Parse(record[2].Trim()), double.Parse(record[3].Trim()));
                        }

                        rekeningen.Add(b);
                    }
                }
            }

            UpdatenCombobox();
            comboBoxRekeningen.SelectedIndex = -1;

            ToonOfVerbergFormulierElementen(false,227);
        }

        private void buttonNieuw_Click(object sender, EventArgs e)
        {
            Bankrekening rekeningKlant;

            if (textBoxRekeningnummer.Text != "")
            {
                if (ControleerValuta(textBoxSaldo.Text, out double valuta, "Foutief of geen Saldo opgegeven, Saldo word ingesteld op €0,00"))
                {
                    rekeningKlant = new Zichtrekening("Z" + textBoxRekeningnummer.Text, valuta);

                    if (rdbSpaarrekening.Checked)
                    {
                        rekeningKlant = new Spaarrekening("S" + textBoxRekeningnummer.Text, valuta);
                    }

                    if (!ControleerDubbelRekeningnummer(rekeningKlant))
                    {
                        ToonOfVerbergFormulierElementen();

                        rekeningen.Add(rekeningKlant);
                        UpdatenCombobox();
                        comboBoxRekeningen.SelectedIndex = comboBoxRekeningen.FindString(rekeningKlant.ToString());
                        labelOverzicht.Text = rekeningKlant.Toongegevens();
                    }
                    else
                    {
                        MessageBox.Show("Rekeningnummer bestaat al!", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vul een rekeningnummer in!", "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxSaldo.Clear();
            textBoxRekeningnummer.Clear();
        } 

        private void buttonVariabelLimRente_Click(object sender, EventArgs e)
        {
            int index = comboBoxRekeningen.SelectedIndex;

            if (ControleerValuta(textBoxVariabelLimRente.Text,out double variabelLimietRente,  $"Foutief of geen {labelVariabelLimRente.Text.Substring(0,6).Trim()} opgegeven"))
            {
                try
                {
                    if (rekeningen[index] is Zichtrekening z)
                    {
                        z.Limiet = variabelLimietRente;
                    }
                    else
                    {
                        Spaarrekening s = (Spaarrekening)rekeningen[index];
                        s.Rente = variabelLimietRente;
                    }

                    LijstUpdaten(rekeningen[index], index);
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Let op", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            textBoxVariabelLimRente.Clear();
        }

        private void buttonStorten_Click(object sender, EventArgs e)
        {
            StortOfAfhalenBedrag();
        }

        private void buttonAfhalen_Click(object sender, EventArgs e)
        {
            StortOfAfhalenBedrag(false);
        }

        private void comboBoxRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRekeningen.SelectedIndex > -1)
            {
                labelVariabelLimRente.Text = "Limiet(optioneel):"; //als er met zichtrekening wordt gewerkt
                buttonVariabelLimRente.Text = "Limiet instellen";

                if (comboBoxRekeningen.SelectedItem.GetType() == typeof(Spaarrekening))
                {   //aanpassen als er met een Spaarrekening gewerkt word, limiet veranderd in rente!
                    labelVariabelLimRente.Text = "Rente :";
                    buttonVariabelLimRente.Text = "Rente instellen";
                }

                ToonOfVerbergFormulierElementen();

                labelOverzicht.Text = rekeningen[comboBoxRekeningen.SelectedIndex].Toongegevens();
            }
            
        }

        private void buttonOverzicht_Click(object sender, EventArgs e)
        {
            string lijn = "Overzicht van alle rekeningen:";
            string tekenreeks = new string('*', lijn.Count());
            lijn += Environment.NewLine + tekenreeks + Environment.NewLine;

            if (rekeningen.Count >0)
            {
                foreach (var item in rekeningen)
                {
                    lijn += item.ToString() + Environment.NewLine;
                }
            }
            else
            {
                lijn += "Momenteel geen geopende rekeningen!" + Environment.NewLine;
            }

            lijn += tekenreeks;

            MessageBox.Show(lijn);
        }

        private void buttonSluiten_Click(object sender, EventArgs e)
        {
            using (StreamWriter teSchrijvenBestand = new StreamWriter("bankrekening.txt"))
            {
                for (int i = 0; i < rekeningen.Count; i++) //hier komt witregel vanonder in het bestand, bij het inlezen wordt nu gecontroleerd op isnullorempty
                {
                    if (rekeningen[i] is Zichtrekening z)
                    {
                        teSchrijvenBestand.WriteLine(z.Bankrekeningnummer + ";" + z.Saldo + ";" + z.AantalVerrichtingen + ";" + z.Limiet);
                    }
                    else
                    {
                        Spaarrekening s = (Spaarrekening)rekeningen[i];
                        teSchrijvenBestand.WriteLine(s.Bankrekeningnummer + ";" + s.Saldo + ";" + s.AantalVerrichtingen + ";" + s.Rente);
                    }
                }
            }

            this.Close();
        }
    }
}