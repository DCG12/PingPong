using Firebase.Database;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Columns.Add("Nombre", 150);
            listView.Columns.Add("Apellido", 150);
            listView.Columns.Add("ID", 150);

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
            var p1 = await child.PostAsync(jug1);
            Console.WriteLine($"{p1.Key}");
            jug1.Id = p1.Key;

            listaJugadores.Add(jug1);
        }

        private async Task llegirFDAsync()
        {
            String msg = "";

            var firebase = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.Id = p1.Key;

            string puntos = p1.Object.puntos.ToString();
            string partidos = p1.Object.partidos.ToString();

            ListViewItem list = new ListViewItem(p1.Object.nom);

            list.Name = p1.Object.Id;
                
                    if (!listView.Items.ContainsKey(list.Name))
                    {
                        string[] fila = { p1.Object.nom, p1.Object.cognom, p1.Object.Id };
                        ListViewItem item = new ListViewItem(fila);
                        listView.Items.Add(item);

                    }
            }
    }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0) { await llegirFDAsync(); }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }
    }
    }

