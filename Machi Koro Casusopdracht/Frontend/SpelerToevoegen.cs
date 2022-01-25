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
    public partial class SpelerToevoegen : Form
    {
        public SpelerToevoegen()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_NaamSpeler_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetSpelerNaam()
        {
            return txtbox_NaamSpeler.Text;
        }

        public bool GetAIKeuze()
        {
            return check_IsRobot.Checked;
        }
    }
}
