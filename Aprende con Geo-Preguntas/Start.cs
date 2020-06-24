using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprende_con_Geo_Preguntas
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Levels nivel = new Levels();
            nivel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
