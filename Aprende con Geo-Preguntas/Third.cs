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
    public partial class Third : Form
    {
        Random rnd;
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;
        Preguntas Preguntas;
        Respuestas Respuestas;
        List<Preguntas> ListaPreguntas;
        List<Respuestas> ListaRespuestas;
        public Third()
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

            Preguntas = new Preguntas(1, 3, "¿Cuál es la capital de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(1, "San Pedro Sula", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Comayagua", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Tegucigalpa", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "Ninguna", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(2, 3, "La cabecera departamental de cortés es:", 10, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(2, "San Pedro Sula", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Comayagua", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Tegucigalpa", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(2, "Ninguna", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(3, 3, "¿Cuántos Departamentos tiene Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(3, "12", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "298", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "17", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(3, "18", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(4, 3, "¿Cuál es el Departamento más grande de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(4, "Islas de la Bahía", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "La Paz", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Olancho", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(4, "Valle", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(5, 3, "El siguiente es un departamento de Honduras", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(5, "San Pedro Sula", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Tegucigalpa", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "La ceiba", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(5, "Ninguna es correcta", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(6, 3, "El lago de Yojoa está ubicado en el departamento de:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(6, "Cortés", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Comayagua", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Santa Bárbara", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(6, "Todas son correctas", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(7, 3, "¿Cuál de los siguientes departamentos es una isla?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(7, "Lempira", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Intibucá", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "El Paraíso", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(7, "Islas de la Bahía", true);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(8, 3, "Tegucigalpa es la cabecera departamental de:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(8, "Gracias Dios", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Francisco Morazan", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Ocotepeque", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Yoro", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(9, 3, "El siguiente departamento de Honduras tiene Frontera con el mara caribe", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(9, "Atlantida", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Yoro", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "El Paraíso", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Ninguna es correcta", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(10, 3, "La moneda oficial de Honduras es:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(10, "Peso", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Lempira", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Quetzal", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "Dólar", false);
            ListaRespuestas.Add(Respuestas);

            Preguntas = new Preguntas(11, 3, "Se le conoce como Capital Industrial de Honduras a:", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(11, "San Pedro Sula", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(11, "Tegucigalpa", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(11, "Roatán", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(11, "Copán", false);
            ListaRespuestas.Add(Respuestas);
        }
        
        public void MostrarPregunta()
        {
            tPregunta.Text = ListaPreguntas[1].Descripcion;

            foreach (Respuestas R in ListaRespuestas)
            {
                if (R.PreguntaID == ListaPreguntas[1].ID)
                {
                    lSetRespuestas.Items.Add(R.Descripcion);
                }
            }

            pTiempo.Maximum = ListaPreguntas[1].Tiempo;
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
                MessageBox.Show("No hay tiempo!");
            }

        }

        private void bServer_Click(object sender, EventArgs e)
        {

        }

        private void lSetRespuestas_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void Third_Load(object sender, EventArgs e)
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

