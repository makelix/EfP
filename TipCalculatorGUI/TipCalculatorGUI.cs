﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculatorGUINS
{
    public partial class TipCalculatorGUI : Form
    {
        public TipCalculatorGUI()
        {
            InitializeComponent();
        }

        private void BillAmount_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Jee!");
        }
    }
}
