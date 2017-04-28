
using System;

namespace PingPong
{   
    class jugador
    {
        public string Id { get; set; }
        public string nom { get; set; }
        public string cognom { get; set; }
        public string foto { get; set; }
        public int puntos { get; set; }
        public int partidos { get; set; }
        public string Codigo { get; set; }

        public jugador()
        {
        }

        public jugador(string id, string nom, string cognom,string foto, int puntos)
        {
            Id = id;
            this.nom = nom;
            this.cognom = cognom;
            this.foto = foto;
            this.puntos = puntos;
            setCodigo();
        }



        public void setCodigo()
        {
            Codigo = nom + "-" + cognom;
        }
    }  
}