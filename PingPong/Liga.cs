using System;
using System.Collections.Generic;

namespace PingPong
{
    class Liga
    {
        List<Partidos> partidos;
            
        public Liga()
        {
            if (partidos==null)
            {
                partidos = new List<Partidos>();
            }
        }

        public Liga(List<Partidos> part)
        {
            partidos = part;
        }

        

    }
}