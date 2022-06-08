using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Album> listAlbum = new List<Album>();
            List<Heroe> listaHeroe = new List<Heroe>();
            Console.WriteLine("Ingrese Código de Album");
            String codigo;
            String nombre;
            String album;
            codigo = Console.ReadLine();
            Console.WriteLine("Ingrese Código de Album");
            nombre = Console.ReadLine();

            listAlbum.Add(new Album(nombre, codigo, listaHeroe));

            Console.WriteLine("Ingrese Código de Heroe");
        
            codigo = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre de Heroe");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Código de Album");
            album = Console.ReadLine();
            Album AlbumEncontrado;

            Heroe heroe = new Heroe(nombre, codigo, "Vuela", 2);
            listaHeroe.Add(heroe);

            AlbumEncontrado = listAlbum.Find(X => X.Codigoalbum == album);

            AlbumEncontrado.Heroes.Add(heroe);
          

        }

    }
}
