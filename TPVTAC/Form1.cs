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
    public partial class ftpvt : Form
    {
        public ftpvt()
        {
            InitializeComponent();
        }

        private void vNavPane1_ExpandedChanged(object sender, VIBlend.WinForms.Controls.vNavItemEventArgs e)
        {

        }

        private void vFieldSet1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vButton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Boolean continuar = true;
            foreach(Form OpenForm in Application.OpenForms) 
            {
                if (OpenForm.GetType() == typeof(fGenericCatalog))
                {
                    MessageBox.Show("Ya esta abierto!");
                    continuar = false;
                }
            }


            if (continuar)
            {*/
            ViBlendTeclado teclado = new ViBlendTeclado();

            //fGenericCatalog fgen = new fGenericCatalog();
            //fgen.Parent = pnlCentral;
            //fgen.Width = pnlCentral.Width;
            //fgen.Height = pnlCentral.Height;
            teclado.Show();
            //}
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
