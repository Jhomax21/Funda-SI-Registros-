using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heroes
{
    public partial class Form1 : Form
    {
        List<Heroe> listHeroe;
        List<Album> listAlbum;
        List<Album> listalbumxHeroes;
        List<AlbumxHero> listaheroesdealbum;
        public Form1()
        {
            InitializeComponent();
            listHeroe = new List<Heroe>();
            listAlbum = new List<Album>();
           
           listaheroesdealbum = new List<AlbumxHero>();

            lvAlbum.View = View.Details;
            lvAlbum.Columns.Add("Album");
            lvAlbum.Columns.Add("Nombre");

            lvHeroesXAlbum.View = View.Details;
            lvHeroesXAlbum.Columns.Add("Código");
            lvHeroesXAlbum.Columns.Add("Nombre");
            lvHeroesXAlbum.Columns.Add("Características");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAlbum.Text.Trim();
            string codigoalbum = txtCodigoAlbum.Text.Trim();
            List<Heroe> lstHeroe = new List<Heroe>();
           

            if (!listAlbum.Exists(X => X.Codigoalbum == codigoalbum))
            {
       
                listAlbum.Add(new Album(nombre, codigoalbum, lstHeroe));
             
                txtCodigoAlbum.Clear();
                txtNombreAlbum.Clear();

                cboAlbum.Items.Add(nombre + "-" + codigoalbum);



                //ActualizarListas();
            }
            else
            {
                MessageBox.Show("Ya existe este album");
            }
        }

        private void ActualizarListas() {

            //cboAlbum.DataSource = null;

            //cboAlbum.DisplayMember = "Nombre";// texto a mostrar en el combo -> atributo o propiedad de la clase
            //cboAlbum.ValueMember = "Codigoalbum";          // valor identificador -> atributo o propiedad de la clase
            //cboAlbum.DataSource = listAlbum; // qué lista va a mostrar

            cboAlbum2.DataSource = null;
            cboAlbum2.DisplayMember = "Nombre";
            cboAlbum2.ValueMember = "Codigoalbum";
            cboAlbum2.DataSource = listAlbum;

            cboHeroe.DataSource = null;
            cboHeroe.DisplayMember = "Nombreheroe";
            cboHeroe.ValueMember = "Codigoheroe";
            cboHeroe.DataSource = listHeroe;

            Album albumMax = null;

            int max = 0;
            foreach (Album aux in listAlbum) {
                if (aux.Heroes.Count > max) {
                    max = aux.Heroes.Count;
                    albumMax = aux;
                }
            }
            if (albumMax != null) {
                lblAlbumMasHeroes.Text = albumMax.Nombre;
            }

            int maxpoder = 0;
            Heroe HeroeMax = null;
            foreach (Heroe aux in listHeroe)
            {
                if (aux.Poder > maxpoder)
                {
                    maxpoder = aux.Poder;
                    HeroeMax = aux;
                }
            }
           // lblHeroesMasPoder.Text = HeroeMax.Nombreheroe;
            


        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreheroe = txtNombreheroe.Text.Trim();
            string codigoheroe = txtCodigoheroe.Text.Trim();
            string caracteristicas = txtcaracteristicaheroe.Text.Trim();
            int poder = Convert.ToInt32(txtPoderheroe.Text.Trim());
            string codigoAlbum = cboAlbum.SelectedValue.ToString(); //captura el valor identificador (no el texto que se muestra)                    
                                    

                if (!listHeroe.Exists(X => X.Codigoheroe == codigoheroe))
                {
                    Heroe heroe = new Heroe(nombreheroe, codigoheroe, caracteristicas, poder);
                    listHeroe.Add(heroe);

                    Album album = listAlbum.Find(p => p.Codigoalbum == codigoAlbum);


                    album.Heroes.Add(heroe);

                    txtNombreheroe.Clear();
                    txtCodigoheroe.Clear();
                    txtcaracteristicaheroe.Clear();
                    txtPoderheroe.Clear();
                    ActualizarListas();
                }
                else {
                    MessageBox.Show("Ya existe este heroe en este Album");
                }                 

              
           
        }

        private void cboAlbum2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void cboHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cboAlbum2_SelectedValueChanged(object sender, EventArgs e)
        {

          
            if (cboAlbum2.SelectedValue is null) return;
            Album album = listAlbum.Find(p => p.Codigoalbum == cboAlbum2.SelectedValue.ToString()); ;
            if (album is null)
                return;


            ListViewItem lvaux;
            if (album.Heroes.Count() == 0)
                return;

            foreach (Heroe heroe in album.Heroes)
            {
                lvHeroesXAlbum.Items.Clear();
                lvaux = new ListViewItem();
                lvaux.Text = heroe.Codigoheroe;
                lvaux.SubItems.Add(heroe.Nombreheroe);
                lvaux.SubItems.Add(heroe.Caracteristicas);

                lvHeroesXAlbum.Items.Add(lvaux);
            }
        }

        private void cboHeroe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboHeroe.Items.Count == 0) return;
            string codHeroe = cboHeroe.SelectedValue.ToString();

            ListViewItem lvaux;
            foreach (Album album in listAlbum)
            {
                if (!album.Heroes.Exists(X => X.Codigoheroe == codHeroe))
                {
                    //ListView:
                    //Instanciar una fila(item) (independiente)
                    lvaux = new ListViewItem();
                    //Contenido Primera Columna
                    lvaux.Text = album.Codigoalbum;
                    //Contenido Segunda Columna
                    lvaux.SubItems.Add(album.Nombre);
                    //Agregar la fila al ListView
                    lvAlbum.Items.Add(lvaux);
                }


            }
        }

        private void cboAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
