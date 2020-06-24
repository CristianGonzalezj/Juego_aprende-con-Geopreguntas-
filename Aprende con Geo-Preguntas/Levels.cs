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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void pTercero_Click(object sender, EventArgs e)
        {
            this.Hide();
            Third Tercero = new Third();
            Tercero.Show();
        }

        private void pCuarto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fourth Cuarto = new Fourth();
            Cuarto.Show();
        }

        private void pQuinto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fifth Quinto = new Fifth();
            Quinto.Show();
        }

        private void pSexto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sixth Sexto = new Sixth();
            Sexto.Show();
        }
    }
}
