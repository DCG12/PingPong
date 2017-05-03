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
    public class jugadorTests
    {
        
        [TestMethod()]
        public void setCodigoTest()
        {
            jugador j = new jugador();
            j.Codigo = "David_Casas";
            Boolean guion;


            if (j.Codigo.Contains("_"))
            {
               guion = true;
            }
            else
            {
                guion = false;
            }
            Assert.IsTrue(guion);
        }
    }
}