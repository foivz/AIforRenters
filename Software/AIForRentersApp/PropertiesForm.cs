﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIForRentersApp
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void buttonShowListOfUnits_Click(object sender, EventArgs e)
        {
            UnitsForm unitsForm = new UnitsForm();
            unitsForm.MdiParent = MainForm.ActiveForm;
            unitsForm.Show();
        }
    }
}
