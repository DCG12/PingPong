using System.Collections.Generic;

namespace PingPong
{
    internal class Liga
    {
        private string nombreLiga;

        private List<jugador> Jugadors;

        public Liga()
        {
            Jugadors = new List<jugador>();
        }

        public void NewJugador(jugador jugador)
        {
            Jugadors.Add(jugador);
        }

        public jugador getJugador(int i)
        {
            if (i < Jugadors.Count)
                return Jugadors[i];
            else
                return null;
        }

        public override string ToString()
        {
            string msg = "";

            foreach (jugador jug in Jugadors)
                msg = msg + jug.ToString() + "\n";

            return msg;
        }
    }
}