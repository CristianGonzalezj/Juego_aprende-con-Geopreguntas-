using System;
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
    public partial class Sixth : Form
    { //Original
        Random rnd = new Random();
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;
        int imagera, Puntos, intento;
        Preguntas Preguntas;
        Respuestas Respuestas;
        List<Preguntas> ListaPreguntas;
        List<Respuestas> ListaRespuestas;
        public Sixth()
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
                    //llenar tabla 
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
                MessageBox.Show("No hay tiempo!");
            }

        }
        private void Sixth_Load(object sender, EventArgs e)
        {
            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            P.Add(p4);
            P.Add(p5);
            P.Add(p6);
            P.Add(p7);
            P.Add(p8);
            Tabla.Columns.Add(new DataColumn("RESPUESTA")); //crear columna para la tabla
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

            Preguntas = new Preguntas(1, 6, "Seleccione un país de Europa", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(1, "China", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Brasil", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "España", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Australia", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(2, 6, "El siguiente es un Océano:", 5, 5);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(2, "Atlántico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Pacífico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Índico", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Todos son correctos", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(3, 6, "¿Cuál es el continente mas grande del mundo?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(3, "América", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Europa", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "África", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Asia", true);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(4, 6, "¿A que continente pertenece Groenlandia?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(4, "América", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Polo Norte", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Oceanía", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Asia", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(5, 6, "¿Cuál es el monte más grande del mundo?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(5, "Everest", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Huascaran", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Aconcagua", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Amazonas", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(6, 6, "Cuales el idioma oficial de Brasil?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(6, "Español", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Ingles", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Portugués", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Árabe", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(7, 6, "¿Cual de los siguientes no es un planeta?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(7, "Tierra", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Neptuno", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Jupiter", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Luna", true);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(8, 6, "¿Cual es la densidad poblacional en honduras por Km2?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(8, "100 habitantes", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "50 habitantes", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "85 habitantes", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Ninguna de las anteriores", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(9, 6, "¿Cual es la densidad poblacional a nivel mundial por Km2?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(9, "49 habitantes", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "200 habitantes", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "18 habitantes", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Todas son correctas", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(10,6, "¿Cual es el país con mas agua dulce del mundo?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(10, "Estados unidos", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "China", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Honduras", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Rusia", true);
            ListaRespuestas.Add(Respuestas);
        }

        private void tPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int Renglonn = e.RowIndex;
            string resp = dataGridView1.Rows[Renglonn].Cells[1].Value.ToString();
            if (resp == "True")
            {
                MessageBox.Show("Respuesta Correcta");
                Puntos = Puntos + ListaPreguntas[imagera].Valor;//sumar respuestas correctas
                tPuntos.Text = Puntos.ToString(); //asignar respuetas a textbox
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
                intento++; //sumar equivocaciones
                tEquivocaciones.Text = intento.ToString();//asignar a textbox
            }
            if (intento == 3)
            {
                MessageBox.Show("Alcanzo el numero maximo de intentos ");
                this.Close();
                Levels Levels = new Levels();
                Levels.Show();
            }
            Tabla.Clear();//limpiar tabla
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

