using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tablas tables = new tablas();
            tables.llenarArreglos();
            String item;
            String[] itemArray;
            item = tables.Getab1().GetValue(0).ToString();
            itemArray = item.Split('-');
            rbelectrico.Text = itemArray[1];

            item = tables.Getab1().GetValue(1).ToString();
            itemArray = item.Split('-');
            rbmanual.Text = itemArray[1];

            item = tables.Gettab2().GetValue(0).ToString();
            itemArray = item.Split('-');
            sboferta.Items.Add(itemArray[1].Trim());

            item = tables.Gettab2().GetValue(1).ToString();
            itemArray = item.Split('-');
            sboferta.Items.Add(itemArray[1].Trim());

            item = tables.Gettab2().GetValue(2).ToString();
            itemArray = item.Split('-');
            sboferta.Items.Add(itemArray[1].Trim());

            item = tables.Gettab2().GetValue(3).ToString();
            itemArray = item.Split('-');
            sboferta.Items.Add(itemArray[1].Trim());

            listView1.View = View.Details;
            listView1.Columns.Add("Scooter");
            listView1.Columns.Add("Oferta");
            listView1.Columns.Add("Precio");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            tablas tables = new tablas();
            String aux_tipo = rbelectrico.Checked ? rbelectrico.Text : rbmanual.Text;
            lv1.Text = aux_tipo;
            lv1.SubItems.Add(sboferta.SelectedItem.ToString());
            double aux_costo = tables.aumentarprecio(rbelectrico.Checked, Convert.ToDouble(lbprecio.Text));

            lv1.SubItems.Add(aux_costo.ToString());
            listView1.Items.Add(lv1);

            int aux_11 = 0, aux_19 = 0, aux_31 = 0, aux_free = 0;
          

            foreach (ListViewItem itemFila in listView1.Items)
            {
                if (itemFila.SubItems[1].Text == "11km")
                {
                    aux_11++;
        
                  
                }
                else if (itemFila.SubItems[1].Text == "31km")
                {
                    aux_31++;
                  
                }
                else if (itemFila.SubItems[1].Text == "19km")
                {
                    aux_19++;

                }
                else
                {
                    aux_free++;
                   
                }

            }
       
            labelcant11.Text = aux_11.ToString();
            labelcant19.Text = aux_19.ToString();
            labelcant31.Text = aux_31.ToString();
            labelcantfree.Text = aux_free.ToString();



     



        }

        private void sboferta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sboferta.SelectedItem.ToString() == "11km")
            {
                lbprecio.Text = "5.0";
            }
            else if (sboferta.SelectedItem.ToString() == "19km")
            {
                lbprecio.Text = "12.0";
            }
            else if (sboferta.SelectedItem.ToString() == "31km")
            {
                lbprecio.Text = "20.0";
            }
            else
            {
                lbprecio.Text = "40.0";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
