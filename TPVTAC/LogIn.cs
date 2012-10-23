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
    public partial class LogIn : Form
    {
        dbUsuarios _modUsuarios = new dbUsuarios();

        public LogIn()
        {
            InitializeComponent();
            
        }  

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {
                FvalidaUsuario();
            }
            else {
                MessageBox.Show("Favor de capturar el Usuario");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FconsultaUsuarios()
        {
            DataTable dtUsuarios = new DataTable();
            if (_modUsuarios.getUsuarios(out dtUsuarios))
            {


            }

        }

        private void FvalidaUsuario()
        {
            String _pswd; 
            DataTable dtUsuarios = new DataTable();
            if (_modUsuarios.validaUsuario(txtUsuario.Text, out dtUsuarios))
            {
                if (dtUsuarios.Rows.Count > 0)
                {
                    DataRow dtrow = dtUsuarios.Rows[0];
                    _pswd = dtrow["PWD"].ToString().Trim();
                    if (_pswd == txtPassword.Text.Trim())
                    {
                        //Cerrar la Ventana Actual y cargar la ventana de ftpvt
                        //ftpvt frmtpvt = new ftpvt();
                        //frmtpvt.Show();
                        this.DialogResult = DialogResult.OK;
                        //this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectos");
                    }
                }
                else 
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }

            }

        }




    }
}
