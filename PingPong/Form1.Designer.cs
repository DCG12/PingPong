namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Añadir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewLiga = new System.Windows.Forms.ListView();
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cognom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCrearLiga = new System.Windows.Forms.Button();
            this.Jugador1txt = new System.Windows.Forms.TextBox();
            this.resultado1txt = new System.Windows.Forms.TextBox();
            this.Jugador2txt = new System.Windows.Forms.TextBox();
            this.resultado2txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.btClass = new System.Windows.Forms.Button();
            this.Instrucciones = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(221, 429);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(75, 23);
            this.Añadir.TabIndex = 0;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(25, 432);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(149, 20);
            this.Nombre.TabIndex = 4;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(25, 488);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(149, 20);
            this.Apellido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "LISTA DE JUGADORES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CLASIFICACION LIGA";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(454, 412);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(473, 225);
            this.listView.TabIndex = 19;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewLiga
            // 
            this.listViewLiga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom,
            this.cognom,
            this.partidos,
            this.puntos});
            this.listViewLiga.Location = new System.Drawing.Point(25, 35);
            this.listViewLiga.Name = "listViewLiga";
            this.listViewLiga.Size = new System.Drawing.Size(529, 179);
            this.listViewLiga.TabIndex = 21;
            this.listViewLiga.UseCompatibleStateImageBehavior = false;
            this.listViewLiga.View = System.Windows.Forms.View.Details;
            // 
            // nom
            // 
            this.nom.Text = "Nombre";
            this.nom.Width = 148;
            // 
            // cognom
            // 
            this.cognom.Text = "Apellido";
            // 
            // partidos
            // 
            this.partidos.Text = "Partidos";
            // 
            // puntos
            // 
            this.puntos.Text = "Puntos";
            this.puntos.Width = 114;
            // 
            // btCrearLiga
            // 
            this.btCrearLiga.Location = new System.Drawing.Point(75, 239);
            this.btCrearLiga.Name = "btCrearLiga";
            this.btCrearLiga.Size = new System.Drawing.Size(75, 23);
            this.btCrearLiga.TabIndex = 22;
            this.btCrearLiga.Text = "Crear Liga";
            this.btCrearLiga.UseVisualStyleBackColor = true;
            this.btCrearLiga.Click += new System.EventHandler(this.btCrearLiga_Click);
            // 
            // Jugador1txt
            // 
            this.Jugador1txt.Location = new System.Drawing.Point(75, 292);
            this.Jugador1txt.Name = "Jugador1txt";
            this.Jugador1txt.Size = new System.Drawing.Size(100, 20);
            this.Jugador1txt.TabIndex = 23;
            // 
            // resultado1txt
            // 
            this.resultado1txt.Location = new System.Drawing.Point(199, 292);
            this.resultado1txt.Name = "resultado1txt";
            this.resultado1txt.Size = new System.Drawing.Size(100, 20);
            this.resultado1txt.TabIndex = 24;
            // 
            // Jugador2txt
            // 
            this.Jugador2txt.Location = new System.Drawing.Point(327, 292);
            this.Jugador2txt.Name = "Jugador2txt";
            this.Jugador2txt.Size = new System.Drawing.Size(100, 20);
            this.Jugador2txt.TabIndex = 25;
            // 
            // resultado2txt
            // 
            this.resultado2txt.Location = new System.Drawing.Point(454, 292);
            this.resultado2txt.Name = "resultado2txt";
            this.resultado2txt.Size = new System.Drawing.Size(100, 20);
            this.resultado2txt.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Jugador 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "resultado Jugador 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Jugador 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Resultado jugador 2";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(78, 334);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 31;
            this.Guardar.Text = "Grardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(171, 334);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 32;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // btClass
            // 
            this.btClass.Location = new System.Drawing.Point(171, 239);
            this.btClass.Name = "btClass";
            this.btClass.Size = new System.Drawing.Size(75, 23);
            this.btClass.TabIndex = 33;
            this.btClass.Text = "Clasificacion";
            this.btClass.UseVisualStyleBackColor = true;
            this.btClass.Click += new System.EventHandler(this.Clasificacion_Click);
            // 
            // Instrucciones
            // 
            this.Instrucciones.Location = new System.Drawing.Point(571, 35);
            this.Instrucciones.Multiline = true;
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(356, 179);
            this.Instrucciones.TabIndex = 34;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(221, 461);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 35;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "JUGADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "INSTRUCCIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.Instrucciones);
            this.Controls.Add(this.btClass);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultado2txt);
            this.Controls.Add(this.Jugador2txt);
            this.Controls.Add(this.resultado1txt);
            this.Controls.Add(this.Jugador1txt);
            this.Controls.Add(this.btCrearLiga);
            this.Controls.Add(this.listViewLiga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Añadir);
            this.MinimumSize = new System.Drawing.Size(955, 687);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewLiga;
        private System.Windows.Forms.Button btCrearLiga;
        private System.Windows.Forms.TextBox Jugador1txt;
        private System.Windows.Forms.TextBox resultado1txt;
        private System.Windows.Forms.TextBox Jugador2txt;
        private System.Windows.Forms.TextBox resultado2txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button btClass;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader puntos;
        private System.Windows.Forms.ColumnHeader partidos;
        private System.Windows.Forms.ColumnHeader cognom;
        private System.Windows.Forms.TextBox Instrucciones;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}

