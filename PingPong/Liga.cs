using System.Collections.Generic;

namespace PingPong
{
    internal class Liga
    {
        List<jugador> listaJugadores = new List<jugador>();
        List<Partidos> listaPartidos = new List<Partidos>();

        public void Newplayer(jugador player)
        {
            listaJugadores.Add(player);
        }


    }
}