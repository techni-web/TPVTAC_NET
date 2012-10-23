using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPVTAC
{
    public partial class fBackgroundWhite : Form
    {
        public fBackgroundWhite()
        {
            InitializeComponent();
        }

        private void fBackgroundWhite_Load(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            if (lg.ShowDialog() == DialogResult.OK) 
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
