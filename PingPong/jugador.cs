
using System;

namespace PingPong
{
   
    class jugador
    {
        

        public jugador(string v1, string v2, string v3)
        {
            this.nom = v1;
            this.cognom = v2;
            this.foto = v3;
        }

        public string Id { get; set; }
        public string nom { get; set; }
        public string cognom { get; set; } 
        public string foto { get; set; }
        public int puntos { get; set; }
        public int partidos { get; set; }
    }

   
}