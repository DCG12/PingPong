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

            btClass.Visible = true;

            //Inializacion del firebase
            var firebase = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var observable = firebase
              .Child("jugadors")
              .AsObservable<jugador>()
              .Subscribe(d =>
              {

              });

            //Instrucciones
            Instrucciones.Text = "Para Iniciar una liga, primero debe pulsar el boton Mostrar para que el List coja los jugadores despues pulsar el boton crear Liga y inmediatamente pulsar el boton siguiente. Si pulsamos Clasificación nos mostrara los jugadores sus partidos y sus puntos segun lo hayamos añadido, en caso de haber"
        + " añadido una nueva puntuación puedes volver a pulsar clasificación y la clasificacion se actulizara. P.D. Hay jugadores de ejemplos ya creados en firebase ";
        }

        public async void Añadir_click(object sender, EventArgs e)
        {
            var client = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
            var child = client.Child("jugadors/");

            jugador jug1 = new jugador();
            jug1.nom = Nombre.Text;
            jug1.cognom = Apellido.Text;
            var p1 = await child.PostAsync(jug1);
            Console.WriteLine($"{p1.Key}");
            jug1.Id = p1.Key;

            listaJugadores.Add(jug1);
        }
    
        public async Task llegirFDAsync()
        {

            //Recoge los datos del firebase, los pone en el list de jugadores y los muestro en el ListView
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
                
                if (!listView.Items.ContainsKey(list.Name))
                {
                    string[] fila = { p1.Object.nom, p1.Object.cognom, p1.Object.Id };
                    ListViewItem item = new ListViewItem(fila);
                    listView.Items.Add(item);
                }
            }

        }

        public async void button3_Click(object sender, EventArgs e)
        {

            //Activa el metodo llegirFDAsync
            await llegirFDAsync();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Borra la información que se muestra en el listView de los jugadores
            listView.Items.Clear();
        }

        private void lig1()
        {

        }

        public void btCrearLiga_Click(object sender, EventArgs e)
        {
            //Crea una nueva liga
            int nPartidos = 0;
            if (liga == null)
            {
                liga = new List<Partidos>();
            }
            if (listaJugadores != null)
            {
                nPartidos = calcularNumeroPartidos();
            }
        }

        public int calcularNumeroPartidos()
        {
            //Calcula el numero de partidos que se tendran jugar en función de los jugadores en el firebase
            int contador = 0;
            Partidos p;
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

        public void Siguiente_Click(object sender, EventArgs e)
        {

            //Nos permite avanzar para poner los resultados de los partidos
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

        public void Guardar_Click(object sender, EventArgs e)
        {
            //Guardar los resultados de los partidos
            string codigoGanador = liga.First(x => x.Equals(partiActual)).setMarcador(int.Parse(resultado1txt.Text), int.Parse(resultado2txt.Text));

            listaJugadores.First(x => x.Codigo.Equals(codigoGanador)).puntos = listaJugadores.First(x => x.Codigo.Equals(codigoGanador)).puntos + 3;
            listaJugadores.First(x => x.Codigo.Equals(codigoGanador)).partidos = listaJugadores.First(x => x.Codigo.Equals(codigoGanador)).partidos + 1;

            if (codigoGanador.Equals(Jugador1txt.Text))
            {
                listaJugadores.First(x => x.Codigo.Equals(Jugador2txt.Text)).partidos = listaJugadores.First(x => x.Codigo.Equals(Jugador2txt.Text)).partidos + 1;
            }
            else
            {
                listaJugadores.First(x => x.Codigo.Equals(Jugador1txt.Text)).partidos = listaJugadores.First(x => x.Codigo.Equals(Jugador1txt.Text)).partidos + 1;
            }
        }

        public void Clasificacion_Click(object sender, EventArgs e)
        {
            //Muestra la información de los jugadores su nombre, apellido, puntuación y partidos jugados
            listViewLiga.Items.Clear();
            foreach (jugador j1 in listaJugadores)
            {
                string[] fila = { j1.nom, j1.cognom, j1.partidos.ToString(), j1.puntos.ToString() };
                ListViewItem item = new ListViewItem(fila);
                listViewLiga.Items.Add(item);
            }


        }

        public async void borrar_Click(object sender, EventArgs e)
        {
            //Elimina los datos del firebase
                var client = new FirebaseClient("https://pingpong-92b64.firebaseio.com/");
                var child = client.Child("jugadors");

                await child.DeleteAsync();

                MessageBox.Show("ok");       
        }
    }
}


