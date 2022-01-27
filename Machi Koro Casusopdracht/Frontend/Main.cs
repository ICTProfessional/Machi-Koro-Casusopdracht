using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machi_Koro_Casusopdracht
{
    public partial class Main : Form
    {
        Toernooi HuidigToernooi;
        Instellingen instellingen;
        public Main()
        {
            instellingen = new Instellingen();
            InitializeComponent();
        }

        private void SpelersResetten()
        {
            foreach (var speler in instellingen.BeschikbareSpelers)
            {
                speler.ResetStats();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Er wordt een speler of AI toegevoegd. Het sluit af wanneer er een lege naam inzit, het (AI) bevat of gelijk is aan een andere spelernaam.
        /// De lijst met spelers wordt geüpdatet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SpelerToevoegen_Click(object sender, EventArgs e)
        {
            SpelerToevoegen spelerToevoegen = new SpelerToevoegen();
            if (spelerToevoegen.ShowDialog() == DialogResult.OK)
            {
                string spelerNaam = spelerToevoegen.GetSpelerNaam();
                if (spelerNaam.Length == 0 || spelerNaam.Contains("(AI)")) { MessageBox.Show("Een normale spelernaam mag niet leeg zijn en mag geen (AI) bevatten.", "Kan speler niet aanmaken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                foreach (var speler in instellingen.BeschikbareSpelers)
                {
                    if (speler.Naam == spelerNaam) { MessageBox.Show("Een spelernaam mag niet gelijk zijn aan een andere spelernaam.", "Kan speler niet aanmaken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                }
                if (spelerToevoegen.GetAIKeuze())
                {
                    instellingen.VoegAIToe(spelerNaam + " (AI)");
;               }
                else
                {
                    instellingen.VoegSpelerToe(spelerNaam);
                }
                UpdateSpelerlijst();
            }
        }

        private void UpdateSpelerlijst()
        {
            lb_SpelerLijst.Items.Clear();
            foreach (var speler in instellingen.BeschikbareSpelers)
            {
                lb_SpelerLijst.Items.Add(speler.Naam);
            }
            
        }

        private void btn_SpelerVerwijderen_Click(object sender, EventArgs e)
        {
            if (lb_SpelerLijst.SelectedItem == null)
            {
                MessageBox.Show("Je hebt geen speler gekozen!", "Kan speler niet verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                return;
            }
            instellingen.VerwijderSpeler(lb_SpelerLijst.SelectedItem.ToString());
            UpdateSpelerlijst();
        }

        private void btn_StartSpel_Click(object sender, EventArgs e)
        {
            if (instellingen.BeschikbareSpelers.Count < 2)
            {
                MessageBox.Show("Er zijn niet genoeg spelers!", "Kan spel niet starten", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SpelersResetten();
            Spelscherm spelscherm = new Spelscherm(instellingen.BeschikbareSpelers, false);
            spelscherm.Show();
        }

        private void btn_Toernooi_Click(object sender, EventArgs e)
        {
            if (instellingen.BeschikbareSpelers.Count < 2)
            {
                MessageBox.Show("Er zijn niet genoeg spelers!", "Kan toernooi niet starten", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            HuidigToernooi = new Toernooi();
            HuidigToernooi.BeschikbareSpelers = instellingen.BeschikbareSpelers.ToList();
            while (HuidigToernooi.BeschikbareSpelers.Count > 1)
            {
                HuidigToernooi.SplitSpelers(HuidigToernooi.BeschikbareSpelers);
                ToernooiScherm toernooiScherm = new ToernooiScherm(HuidigToernooi);
                Spelscherm spel;
                if (toernooiScherm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var groep in HuidigToernooi.SpelerGroepen)
                    {
                        MessageBox.Show(String.Format("Nu zijn {0} en {1} aan de beurt!", groep[0].Naam, groep[1].Naam));
                        spel = new Spelscherm(groep, true);
                        spel.ShowDialog();
                        if (spel.Winnaar != null)
                        {
                            foreach (var speler in groep)
                            {
                                speler.ResetStats();
                            }
                            var groep2 = groep.ToList();
                            groep2.Remove(spel.Winnaar);
                            Speler Verliezer = groep2[0];
                            HuidigToernooi.BeschikbareSpelers.Remove(Verliezer);
                        }
                    }
                }
            }
            Speler ToernooiWinnaar = HuidigToernooi.BeschikbareSpelers[0];
            EindeSpel eindeSpel = new EindeSpel(ToernooiWinnaar.Naam, false);
            eindeSpel.ShowDialog();
        }

        private void btn_Instellingen_Click(object sender, EventArgs e)
        {
            Opties opties = new Opties();
            opties.ShowDialog();
        }
    }
}
