using Firebase.Database;
using System;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
       
        jugador jug1 = new jugador("Anonymous", "Cognom", "no_foto");
        Liga liga1 = new Liga();

        public Form1()
        {
            var firebase = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            jug1.nom = Nombre.Text;

            Nombre2.Text = Nombre.Text;

        }

        private async void insertFDMenuItem_Click(object sender, EventArgs e)
        {

           
            var client = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var child = client.Child("jugadors");

            jugador jug = new jugador("Anonymous", "Cognom", "no_foto");

            
            var p1 = await child.PostAsync(jug);
            jug.Id = p1.Key;
            liga1.NewJugador(jug);

            MessageBox.Show("ok");
        }
    }
}
