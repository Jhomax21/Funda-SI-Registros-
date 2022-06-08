using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_2
{
    public partial class Form1 : Form
    {
        List<Beneficiario> beneficiarios = new List<Beneficiario>();
        public Form1()
        {
            InitializeComponent();
            cbPS.Items.Add("Pension 64");
            cbPS.Items.Add("Programa Juntos");
            cbPS.Items.Add("Contigo");
            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (cbPS.Text == "")
            {
                errorProvider1.SetError(cbPS, "Debe ingresar programa social de la persona");
                cbPS.Focus();
                return;
            }
            errorProvider1.SetError(cbPS, "");
            if (Existe(txtEdad.Text))
            {
                errorProvider1.SetError(txtEdad, "El beneficiario ya se encuentra registrado");
                txtEdad.Focus();
                return;
            }
            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Debe ingresar DNI del beneficiario");
                txtEdad.Focus();
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            if (nudEdad.Value < 18)
            {
                errorProvider1.SetError(nudEdad, "El beneficiario debe tener mas de 18 años");
                nudEdad.Focus();
                return;
            }
            errorProvider1.SetError(nudEdad, "");
            if (cbGenero.Text == "")
            {
                errorProvider1.SetError(cbGenero, "Debe ingresar genero del beneficiario");
                cbGenero.Focus();
                return;
            }
            errorProvider1.SetError(cbGenero, "");
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar Nombre del beneficiario");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");
            if (txtDirección.Text == "")
            {
                errorProvider1.SetError(txtDirección, "Debe ingresar dirección del beneficiario");
                txtDirección.Focus();
                return;
            }
            errorProvider1.SetError(txtDirección, "");



            Beneficiario beneficiario = new Beneficiario();
            beneficiario.Programa = cbPS.Text;
            beneficiario.DNI = Convert.ToInt32( txtEdad.Text);
            beneficiario.Edad = Convert.ToInt32(nudEdad.Value);
            beneficiario.Genero = cbGenero.Text;
            beneficiario.Nombre = txtNombre.Text;
            beneficiario.Dirección = txtDirección.Text;
            beneficiario.Dinero = 350;
            beneficiarios.Add(beneficiario);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = beneficiarios;
            cbGenero.Text = "";
            cbPS.Text = "";
            txtDirección.Clear();
            txtEdad.Clear();
            txtNombre.Clear();         

        }

        private bool Existe(string DNI)
        {
            foreach (Beneficiario bene in beneficiarios)
            {
                if (bene.DNI == Convert.ToInt32( DNI)) return true;
            }
            return false;
        }
    }
}
