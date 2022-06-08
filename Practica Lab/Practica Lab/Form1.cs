using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Lab
{
    public partial class Form1 : Form
    {
        List<Heroe> listah;
        List<Album> listaa;
        List<AlbumxHeroe> listaheroesxalbum;
        public Form1()
        {
            InitializeComponent();
            listah = new List<Heroe>();
            listaa = new List<Album>();
            listaheroesxalbum = new List<AlbumxHeroe>();

            listviewAlbumes.View = View.Details;
            listviewAlbumes.Columns.Add("Album");
            listviewAlbumes.Columns.Add("Nombre");
            listviewHXA.View = View.Details;
            listviewHXA.Columns.Add("Código");
            listviewHXA.Columns.Add("Nombre");
            listviewHXA.Columns.Add("Características");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtNameAlbum.Text.Trim();
            string codalbum = txtCodAlbum.Text.Trim();
            List<Heroe> listaHeroe = new List<Heroe>();


            if (!listaa.Exists(X => X.Codigoalbum == codalbum))
            {

                listaa.Add(new Album(name, codalbum, listaHeroe));
                txtCodAlbum.Clear();
                txtNameAlbum.Clear();

                ActualizarListas();
            }
            else
            {
                MessageBox.Show("El album ya existe");
            }
        }

        private void ActualizarListas()
        {

            cbalbum.DataSource = null;

            cbalbum.DisplayMember = "Nombre";
            cbalbum.ValueMember = "Codigoalbum";
            cbalbum.DataSource = listaa;

            cbAlbum2.DataSource = null;
            cbAlbum2.DisplayMember = "Nombre";
            cbAlbum2.ValueMember = "Codigoalbum";
            cbAlbum2.DataSource = listaa;

            cbHero.DataSource = null;
            cbHero.DisplayMember = "Nombreheroe";
            cbHero.ValueMember = "Codigoheroe";
            cbHero.DataSource = listah;

        }

        private void complementos()
        {
            int maximopoder = 0;
            Heroe HeroeMax = null;
            foreach (Heroe aux in listah)
            {
                if (aux.Poder > maximopoder)
                {
                    maximopoder = aux.Poder;
                    HeroeMax = aux;
                }
            }
            labelHeroesMayotPoder.Text = HeroeMax.Nombreheroe;

            Album albumMax = null;

            int maxi = 0;
            foreach (Album aux in listaa)
            {
                if (aux.Heroes.Count > maxi)
                {
                    maxi = aux.Heroes.Count;
                    albumMax = aux;
                }
            }
            if (albumMax != null)
            {
                labelAlbumconmasHeroes.Text = albumMax.Nombre;
            }
            int menpoder = 1000000;
            Heroe HeroeMen = null;
            foreach (Heroe aux in listah)
            {
                if (aux.Poder < menpoder)
                {
                    menpoder = aux.Poder;
                    HeroeMen = aux;
                }
            }
            labelheroeMenorPoder.Text = HeroeMen.Nombreheroe;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string nameheroe = txtNombrheroe.Text.Trim();
            string codheroe = txtCodiheroe.Text.Trim();
            string caracteristicas = txtcaracteristicahero.Text.Trim();
            int poder = Convert.ToInt32(txtpoderhero.Text.Trim());
            string codAlbum = cbalbum.SelectedValue.ToString();

            if (!listah.Exists(X => X.Codigoheroe == codheroe))
            {
                Heroe heroe = new Heroe(nameheroe, codheroe, caracteristicas, poder);
                listah.Add(heroe);

                Album album = listaa.Find(p => p.Codigoalbum == codAlbum);
                album.Heroes.Add(heroe);

                txtNombrheroe.Clear();
                txtCodiheroe.Clear();
                txtcaracteristicahero.Clear();
                txtpoderhero.Clear();
                ActualizarListas();
            }
            else
            {
                MessageBox.Show("Ya existe este heroe en el Album");
            }



        }



        private void cboAlbum2_SelectedValueChanged(object sender, EventArgs e)
        {


            if (cbAlbum2.SelectedValue is null) return;
            Album album = listaa.Find(p => p.Codigoalbum == cbAlbum2.SelectedValue.ToString()); ;
            if (album is null)
                return;
            listviewHXA.Items.Clear();

            ListViewItem lvaux;
            if (album.Heroes.Count() == 0)
                return;
            lvaux = new ListViewItem();
            foreach (Heroe heroe in album.Heroes)
            {

                lvaux = new ListViewItem();
                lvaux.Text = heroe.Codigoheroe;
                lvaux.SubItems.Add(heroe.Nombreheroe);
                lvaux.SubItems.Add(heroe.Caracteristicas);

                listviewHXA.Items.Add(lvaux);
            }
        }

        private void cboHeroe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbHero.Items.Count == 0) return;
            string codHeroe = cbHero.SelectedValue.ToString();
            listviewAlbumes.Items.Clear();

            ListViewItem lvaux;
            foreach (Album album in listaa)
            {
                if (album.Heroes.Exists(X => X.Codigoheroe == codHeroe))
                {

                    lvaux = new ListViewItem();

                    lvaux.Text = album.Codigoalbum;

                    lvaux.SubItems.Add(album.Nombre);

                    listviewAlbumes.Items.Add(lvaux);
                }


            }
        }

        private void cboAlbum_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            complementos();
        }
    }
}
