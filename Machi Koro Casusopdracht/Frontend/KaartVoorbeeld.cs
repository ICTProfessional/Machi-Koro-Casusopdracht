﻿using System;
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
    public partial class KaartVoorbeeld : Form
    {
        public KaartVoorbeeld(Image _kaartImage)
        {
            InitializeComponent();
            img_KaartVoorbeeld.Image = _kaartImage;
        }
    }
}
