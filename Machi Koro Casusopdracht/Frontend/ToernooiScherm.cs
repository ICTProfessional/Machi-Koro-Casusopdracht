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
    public partial class ToernooiScherm : Form
    {
        Toernooi HuidigToernooi;
        public ToernooiScherm(Toernooi _toernooi)
        {
            HuidigToernooi = _toernooi;
            InitializeComponent();
            List<List<Speler>> spelerGroepen = HuidigToernooi.SpelerGroepen;
            foreach (var spelerGroep in spelerGroepen)
            {
                lb_Spelergroepen.Items.Add(spelerGroep[0].Naam + " en " + spelerGroep[1].Naam);
            }
        }

        private void lb_Spelergroepen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_BeginToernooi_Click(object sender, EventArgs e)
        {

        }
    }
}
