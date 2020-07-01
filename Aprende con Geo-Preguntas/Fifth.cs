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
    public partial class Fifth : Form
    {
        Random rnd;
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;

        Preguntas Preguntas;
        Respuestas Respuestas;
        List<Preguntas> ListaPreguntas;
        List<Respuestas> ListaRespuestas;
        public Fifth()
        {
            InitializeComponent();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenRandom = GetRandomNumber(8, 40);
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

        private void MainPreguntas_Load(object sender, EventArgs e)
        {
            
        }

        public int GetRandomNumber(double min, double max)
        {
            rnd = new Random();
            return Convert.ToInt32(rnd.NextDouble() * (max - min) + min);
        }

        public void CargarPreguntas()
        {
            ListaPreguntas = new List<Preguntas>();
            ListaRespuestas = new List<Respuestas>();

            Preguntas = new Preguntas(1, 5, "¿Cuántos países conforman el continente Americano?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(1, "35", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "18", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "298", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "33", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(2, 5, "¿Cuál es el país mas grande de América?:", 5, 5);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(2, "Brasil", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Estados Unidos", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Argentina", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Canadá", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(3, 5, "Es un instrumento utilizado para hacer estudios geográficos:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(3, "Guitarra", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Microscopio", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Brújula", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "Regla", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(4, 5, "¿En que departamento se encuentra ubicado un sitio arqueológico?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(4, "Yoro", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Copán", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Francisco Morazan", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Valle", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(5, 5, "El siguiente es un puerto de Honduras", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(5, "Puerto Cortés", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Puerto de Guayaquil", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Puerto de Manzanillo", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Todos son correctos", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(6, 5, "¿Cuantos aeropuertos internacionales tiene Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(6, "2", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "3", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "4", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "ninguno", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(7, 5, "¿Cuál es el país mas poblado de América?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(7, "Honduras", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Estados Unidos", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Brasil", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Canadá", false);
            ListaRespuestas.Add(Respuestas);

        }

        public void MostrarPregunta()
        {
            tPregunta.Text = ListaPreguntas[0].Descripcion;

            foreach (Respuestas R in ListaRespuestas)
            {
                if (R.PreguntaID == ListaPreguntas[0].ID)
                {
                    lSetRespuestas.Items.Add(R.Descripcion);
                }
            }

            pTiempo.Maximum = ListaPreguntas[0].Tiempo;
            pTiempo.Value = pTiempo.Maximum;
            timerTiempo.Enabled = true;
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

        private void Fifth_Load(object sender, EventArgs e)
        {
            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            P.Add(p4);
            P.Add(p5);
            P.Add(p6);
            P.Add(p7);
            P.Add(p8);
        }
    }
    }
 
