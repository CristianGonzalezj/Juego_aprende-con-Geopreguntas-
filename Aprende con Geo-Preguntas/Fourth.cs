﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Aprende_con_Geo_Preguntas
{
    public partial class Fourth : Form
    {
        Random rnd = new Random();
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;
        int imagera, Puntos, intento;//nuevo
        Preguntas Preguntas;
        Respuestas Respuestas;
        List<Preguntas> ListaPreguntas;
        List<Respuestas> ListaRespuestas;

        public Fourth()
        {
            InitializeComponent();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            Tabla.Clear();
            tPregunta.Clear();
            try
            {
                ImagenRandom = GetRandomNumber(8, 40);
                imagera = GetRandomNumber(1, 9);
                tRuleta.Enabled = true;
                PictureBoxSeleccionado = 1;

                CargarPreguntas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tRuleta_Tick(object sender, EventArgs e)
        {
            if (ImagenRandom > 0)
            {
                Ruleta(ref P);
                ImagenRandom--;
            }
            else
            {
                tRuleta.Enabled = false;
                MostrarPregunta();
            }
        }
        public void ClearList()
        {
            tPregunta.Clear();
            lSetRespuestas.Items.Clear();
        }
        public int GetRandomNumber(double min, double max)
        {
            rnd = new Random();
            return Convert.ToInt32(rnd.NextDouble() * (max - min) + min);
        }
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        DataTable Tabla = new DataTable();
        DataRow Renglon;
        public void MostrarPregunta()
        {
            tPregunta.Text = ListaPreguntas[imagera].Descripcion;
            foreach (Respuestas R in ListaRespuestas)
            {
                if (R.PreguntaID == ListaPreguntas[imagera].ID)
                {
                    lSetRespuestas.Items.Add(R.Descripcion);
                  
                    Renglon = Tabla.NewRow();
                    Renglon[0] = R.Descripcion;
                    Renglon[1] = R.Correcta;
                    Tabla.Rows.Add(Renglon);
                    dataGridView1.DataSource = Tabla;
                    dataGridView1.Columns[1].Visible = false;

                }
                pTiempo.Maximum = ListaPreguntas[imagera].Tiempo;
                pTiempo.Value = 0;
                timer1.Start();

            }
        }
        private void lSetRespuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Respuestas.Correcta.ToString());
            ClearList();
        }
        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            if (pTiempo.Value > 0)
            {
                pTiempo.Value--;
            }
            else
            {
                timerTiempo.Enabled = false;
                MessageBox.Show("No hay Tiempo!");
            }
        }
        private void Fourth_Load(object sender, EventArgs e)
        {
            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            P.Add(p4);
            P.Add(p5);
            P.Add(p6);
            P.Add(p7);
            P.Add(p8);
            Tabla.Columns.Add(new DataColumn("RESPUESTA"));
            Tabla.Columns.Add(new DataColumn("ID"));
        }
        private void Ruleta(ref List<PictureBox> Preguntas)
        {
            foreach (PictureBox P in Preguntas)
            {
                P.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\PreguntaImage.jpg";
            }

            switch (PictureBoxSeleccionado)
            {
                case 1:
                    p1.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 2:
                    p2.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 3:
                    p3.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 4:
                    p4.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 5:
                    p5.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 6:
                    p6.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 7:
                    p7.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    break;
                case 8:
                    p8.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"bin\Pregunta Seleccionada.jpg";
                    PictureBoxSeleccionado = 0;
                    break;
            }
            PictureBoxSeleccionado++;
        }

        public void CargarPreguntas()
        {
            ListaPreguntas = new List<Preguntas>();
            ListaRespuestas = new List<Respuestas>();

            Preguntas = new Preguntas(1, 4, "Es un movimiento que efectua la tierra girando sobre su propio eje", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(1, "Traslasión", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Rotación", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Temblor", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Sismo", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(2, 4, "Es una capa de la tierra:", 5, 5);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(2, "Corteza", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Manto", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Núcleo", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Todas son correctas", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(3, 4, "Es una coordenada Geográfica", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(3, "Latitud", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Meridiano", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Ecuador", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Ninguna", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(4, 4, "Honduras está ubicada en el continente de:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(4, "América", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Europa", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "África", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Asia", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(5, 4, "¿En qué región de América se encuentra ubicada Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(5, "América del Norte", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "América Central", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "América Insular", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "América del sur", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(6, 4, "¿Cuáles son los océanos que bañan las costas de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(6, "Oceáno Atlántico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Oceáno Pacífico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Oceáno Índico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "a y b son correctas", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(7, 4, "El siguiente es un río de Honduras:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(7, "Río Ulúa", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Río Amazonas", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Río Nilo", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Río Misisipi", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(8, 4, "¿Cuál es la extensión territorial de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(8, "112,492 m2", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "112,492 km2", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "136,700 km", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Ninguna de las anteriores", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(9, 4, "El siguiente no es un país de Centroamérica", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(9, "Guatemala", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Panamá", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Colombia", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "El Salvador", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(10, 4, "¿Cuál de los siguientes departamentos no tiene contacto con el mar?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(10, "Cortés", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Gracias a Dios", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Comayagua", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Valle", false);
            ListaRespuestas.Add(Respuestas);
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Renglonn = e.RowIndex;
            string resp = dataGridView1.Rows[Renglonn].Cells[1].Value.ToString();
            if (resp == "True")
            {
                MessageBox.Show("Respuesta Correcta");
                Puntos = Puntos + ListaPreguntas[imagera].Valor;
                tPuntos.Text = Puntos.ToString();
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
                intento++; 
                tEquivocaciones.Text = intento.ToString();
            }
            if (intento == 3)
            {
                MessageBox.Show("Alcanzo el numero maximo de intentos ");
                this.Close();
                Levels Levels = new Levels();
                Levels.Show();
            }
            Tabla.Clear();
            tPregunta.Clear();
            pTiempo.Value = 0;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pTiempo.Increment(1);
            if (pTiempo.Value == ListaPreguntas[imagera].Tiempo)
            {
                timer1.Stop();
                Tabla.Clear();
                tPregunta.Clear();
                MessageBox.Show("Se Acabo El Tiempo");
                intento++;
                tEquivocaciones.Text = intento.ToString();
                if (intento == 3)
                {
                    MessageBox.Show("Alcanzo el numero maximo de intentos ");
                    this.Close();
                    Levels Levels = new Levels();
                    Levels.Show();
                }
            }
        }
    }

}
