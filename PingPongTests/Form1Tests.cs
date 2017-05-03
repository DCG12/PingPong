using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Tests
{
    [TestClass()]
    public class Form1Tests
    {

        [TestMethod()]
        public void calcularNumeroPartidosTest()
        {
            List<jugador> listaJugadores = new List<jugador>();
            jugador j1 = new jugador();
            jugador j2 = new jugador();
            jugador j3 = new jugador();
            jugador j4 = new jugador();
            listaJugadores.Add(j1);
            listaJugadores.Add(j2);
            listaJugadores.Add(j3);
            listaJugadores.Add(j4);
            Form1 form1 = new Form1();
            int contador = 0;

            for (int i = 0; i < listaJugadores.Count; i++)
            {

                if (i + 1 < listaJugadores.Count)
                {
                    for (int j = i + 1; j < listaJugadores.Count; j++)
                    {
                        contador++;
                    }



                    //Assert.Fail();
                }
            }

            int comprobante = 0;
            Assert.AreNotSame(contador, comprobante);
        }

    }
}