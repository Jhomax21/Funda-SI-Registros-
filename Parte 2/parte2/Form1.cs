using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parte2
{
    public partial class Form1 : Form
    {

        List<deliverys> listdeliverys;
        List<empresas> listempresas;
        List<empresaxdelivery> listexd;
        public Form1()
        {
            InitializeComponent();
            listdeliverys = new List<deliverys>();
            listempresas = new List<empresas>();
            listexd = new List<empresaxdelivery>();

            listView1.View = View.Details;
            listView1.Columns.Add("Empresas");
            listView1.Columns.Add("TipodeDElivery");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruc = textBox1.Text.Trim();
            string nombre = textBox2.Text.Trim();
            string direccion = textBox3.Text.Trim();

            if (!listempresas.Exists(X => X.Nombre == nombre))
            {
                listempresas.Add(new empresas(ruc, nombre,direccion));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
          
                comboBox1.Items.Add(nombre);

            }
            else
            {
                MessageBox.Show("Ya existe este codigo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vehiculo = textBox4.Text.Trim();
            string precio = textBox5.Text.Trim();
      

           
                listdeliverys.Add(new deliverys( vehiculo, precio));
                textBox4.Clear();
                textBox5.Clear();
               

                comboBox2.Items.Add(vehiculo);

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string empresa = comboBox1.Text.Trim();
            string delivery = comboBox2.Text.Trim();
            ListViewItem lvaux = new ListViewItem();
            empresaxdelivery dats = new empresaxdelivery();
            dats.Datos = empresa;
            dats.Tipo = delivery;
            lvaux.Text = empresa;
            lvaux.SubItems.Add(delivery);
            listView1.Items.Add(lvaux);

           /* foreach (var item in listexd)
                {
                    lvaux.Text = item.Datos;
                    lvaux.SubItems.Add(item.Tipo);
                    listView1.Items.Add(lvaux);
                }*/

            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
