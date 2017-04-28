namespace PingPong
{
    internal class Partidos
    {
        public string codigoj1 { get; set; }
        public string codigoj2 { get; set; }
        public int marcadorj1 { get; set; }
        public int marcadorj2 { get; set; }
        public bool jugado = false;

        public Partidos()
        {}

        public Partidos(string codj1, string codj2)
        {
            codigoj1 = codj1;
            codigoj2 = codj2;
        }

        public Partidos(string codj1, string codj2, int mar1, int mar2)
        {
            codigoj1 = codj1;
            codigoj2 = codj2;
            marcadorj1 = mar1;
            marcadorj2 = mar2;
        }
        
        public string setMarcador(int mar1, int mar2)
        {
            marcadorj1 = mar1;
            marcadorj2 = mar2;
            jugado = true;

            //if de comparacion de marcadores para saber quien gana, y devuelve el codigo del ganador
            //return codigoj1;
            return null;
        }
    }
}