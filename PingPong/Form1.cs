using Firebase.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
       
       
        Liga liga1 = new Liga();
        List<jugador> listaJugadores = new List<jugador>();


        public Form1()
        {
            InitializeComponent();
          
            var firebase = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var observable = firebase
              .Child("jugadors")
              .AsObservable<jugador>()
              .Subscribe(d => {
                
              });
        }

        

        private async void Añadir_click(object sender, EventArgs e)
        {
            var client = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var child = client.Child("jugadors/");

            jugador jug1 = new jugador();
            jug1.nom = Nombre.Text;
            jug1.cognom = Apellido.Text;
            jug1.foto = Foto.Text;

            listaJugadores.Add(jug1);

            var p1 = await child.PostAsync(jug1);
        }

        private async Task llegirFDAsync()
        {
            String msg = "";

            var firebase = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.Id = p1.Key;
                
                liga1.NewJugador(p1.Object);

                msg = msg + p1.Object.ToString() + "\n";
                listaJugadores.Add(p1.Object);
               
            }

           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = listaJugadores;


        }

        
    }
}
