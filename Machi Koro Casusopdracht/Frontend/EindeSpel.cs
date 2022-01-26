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
    public partial class EindeSpel : Form
    {
        public EindeSpel(string _naamWinnaar, bool isVanToernooi)
        {
            InitializeComponent();
            lbl_Winnaar.Text = String.Format("{0} heeft gewonnen!", _naamWinnaar);
            
            if (isVanToernooi)
            {
                btn_StartScherm.Text = "Ga door naar volgend toernooi spel";
            }
        }

        private void btn_StartScherm_Click(object sender, EventArgs e)
        {

        }
    }
}
