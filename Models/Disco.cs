using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TercerTP.Models
{
    public class Disco
    {
        public string nombre { get; private set;}
        public string productor { get; private set;}
        public string genero { get; private set;}
        public List<Disco> temas {get; private set;}
        public int id  { get; private set;}


        public Disco (string nombre,string productor, string genero, List<Disco> temas, int id )
        {
            this.nombre = nombre;
            this.productor = productor;
            this.genero= genero;
            this.id = id;
        }

    }

    public static void InicializarAlbum()
    {
        Disco disco = new Disco ()
    }
}