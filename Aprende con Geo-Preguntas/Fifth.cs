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
        Random rnd = new Random();
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;
        int imagera, Puntos, intento;
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
            Preguntas = new Preguntas(8, 5, "¿Cuál es el punto más alto de honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(8, "El picacho (Tegucigalpa)", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "El merendon (San Pedro Sula)", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Pico de Celaque(Lempira)", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(8, "Ninguna", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(9, 5, "¿Cuál es el grupo étnico mas numeroso de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(9, "Lencas", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Misquitos", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Chortis", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(9, "Tolupanes", false);
            ListaRespuestas.Add(Respuestas);
            Preguntas = new Preguntas(10, 5, "¿Qué dia se celebra la disque independencia de Honduras?", 8, 10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(10, "21 de septiembre", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "15 de septiembre", true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "1 de mayo", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(10, "29 de junio", false);
            ListaRespuestas.Add(Respuestas);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
    }
}
 
