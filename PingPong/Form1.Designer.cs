﻿namespace PingPong
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
            this.Foto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button3.Location = new System.Drawing.Point(571, 373);
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
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(25, 546);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(149, 20);
            this.Foto.TabIndex = 6;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Foto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lista  de jugadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Liga";
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
            this.button1.Location = new System.Drawing.Point(665, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Foto);
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
        private System.Windows.Forms.TextBox Foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button1;
    }
}

