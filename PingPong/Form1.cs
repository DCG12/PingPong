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
        Partidos partiActual;
        List<Partidos> liga;

        public Form1()
        {
            InitializeComponent();

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Columns.Add("Nombre", 150);
            listView.Columns.Add("Apellido", 150);
            listView.Columns.Add("ID", 150);

            /*
            listViewLiga.View = View.Details;
            listViewLiga.FullRowSelect = true;
            listViewLiga.Columns.Add("Jugador 1", 150);
            listViewLiga.Columns.Add("Jugador 2", 150);
            listViewLiga.Columns.Add("Resultado Judador 1", 50);
            listViewLiga.Columns.Add("Resultado Judador 2", 50);
            */

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

                jugador j = (jugador)p1.Object;
                j.setCodigo();
                listaJugadores.Add(j);


                list.Name = p1.Object.Id;
                //liga1.AfegirJugador(p1.Object);
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
           await llegirFDAsync();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();      
        }

        private void lig1()
        {
           
        }

        private void btCrearLiga_Click(object sender, EventArgs e)
        {
            int nPartidos = 0;
            if (liga == null)
            {
                liga = new List<Partidos>();
            }
            if (listaJugadores != null)
            {
                nPartidos=calcularNumeroPartidos();
            }


        }

        private int calcularNumeroPartidos()
        {
            int contador = 0;
            Partidos p ;
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                
                if (i + 1 < listaJugadores.Count)
                {
                    for (int j = i + 1; j < listaJugadores.Count; j++)
                    {
                        p = new Partidos();
                        p.codigoj1 = listaJugadores[i].Codigo;
                        p.codigoj2 = listaJugadores[j].Codigo;
                        liga.Add(p);
                        contador++;
                    }

                    //liga.Add(p);
                }
                
            }
            return contador;
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            foreach (Partidos p in liga)
            {
                if (!p.jugado)
                {
                    resultado1txt.Text = null; 
                    resultado2txt.Text = null;
                    partiActual = p;
                    Jugador1txt.Text = p.codigoj1;
                    Jugador2txt.Text = p.codigoj2;
                    return;
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string codigo=liga.First(x => x.Equals(partiActual)).setMarcador(int.Parse(resultado1txt.Text),int.Parse(resultado2txt.Text));

            listaJugadores.First(x => x.Codigo.Equals(codigo)).puntos= listaJugadores.First(x => x.Codigo.Equals(codigo)).puntos + 3;
            listaJugadores.First(x => x.Codigo.Equals(codigo)).partidos = listaJugadores.First(x => x.Codigo.Equals(codigo)).partidos + 1;

        }
    }
}

