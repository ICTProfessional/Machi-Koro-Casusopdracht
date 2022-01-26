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
        Toernooi HuidigToernooi = new Toernooi();
        public ToernooiScherm(List<Speler> beschikbareSpelers)
        {
            InitializeComponent();
            HuidigToernooi.BeschikbareSpelers = beschikbareSpelers;
            HuidigToernooi.SplitSpelers(beschikbareSpelers);
            List<List<Speler>> spelerGroepen = HuidigToernooi.SpelerGroepen;
            foreach (var spelerGroep in spelerGroepen)
            {
                lb_Spelergroepen.Items.Add(spelerGroep);
            }
        }
    }
}
