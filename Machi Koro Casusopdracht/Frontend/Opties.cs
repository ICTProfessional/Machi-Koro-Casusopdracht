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
    public partial class Opties : Form
    {
        public Opties()
        {
            InitializeComponent();

        }

        private void btn_Handleiding_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=-mYLss1GlcU");
        }

        private void btn_Spelregels_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.thegameroom.nl/dobbelspellen/machi-koro/");

        }
    }
}
