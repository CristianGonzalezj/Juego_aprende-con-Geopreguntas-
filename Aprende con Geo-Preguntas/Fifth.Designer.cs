namespace Aprende_con_Geo_Preguntas
{
    partial class Fifth
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fifth));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pTiempo = new System.Windows.Forms.ProgressBar();
            this.lSetRespuestas = new System.Windows.Forms.ListBox();
            this.bPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.tRuleta = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tEquivocaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPuntos = new System.Windows.Forms.TextBox();
            this.tPregunta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTiempo
            // 
            this.pTiempo.Location = new System.Drawing.Point(417, 8);
            this.pTiempo.Maximum = 10;
            this.pTiempo.Name = "pTiempo";
            this.pTiempo.Size = new System.Drawing.Size(275, 23);
            this.pTiempo.Step = 1;
            this.pTiempo.TabIndex = 6;
            // 
            // lSetRespuestas
            // 
            this.lSetRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSetRespuestas.FormattingEnabled = true;
            this.lSetRespuestas.ItemHeight = 20;
            this.lSetRespuestas.Location = new System.Drawing.Point(447, 96);
            this.lSetRespuestas.Name = "lSetRespuestas";
            this.lSetRespuestas.Size = new System.Drawing.Size(138, 104);
            this.lSetRespuestas.TabIndex = 26;
            this.lSetRespuestas.SelectedIndexChanged += new System.EventHandler(this.lSetRespuestas_SelectedIndexChanged);
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlay.Location = new System.Drawing.Point(323, 120);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(75, 43);
            this.bPlay.TabIndex = 24;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cuarto Grado";
            // 
            // timerTiempo
            // 
            this.timerTiempo.Interval = 1000;
            // 
            // tRuleta
            // 
            this.tRuleta.Tick += new System.EventHandler(this.tRuleta_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.p8);
            this.panel1.Controls.Add(this.p7);
            this.panel1.Controls.Add(this.p6);
            this.panel1.Controls.Add(this.p5);
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 297);
            this.panel1.TabIndex = 30;
            // 
            // p8
            // 
            this.p8.Image = ((System.Drawing.Image)(resources.GetObject("p8.Image")));
            this.p8.Location = new System.Drawing.Point(51, 189);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(63, 67);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p8.TabIndex = 0;
            this.p8.TabStop = false;
            // 
            // p7
            // 
            this.p7.Image = ((System.Drawing.Image)(resources.GetObject("p7.Image")));
            this.p7.Location = new System.Drawing.Point(120, 219);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(63, 67);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p7.TabIndex = 0;
            this.p7.TabStop = false;
            // 
            // p6
            // 
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.Location = new System.Drawing.Point(189, 189);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(63, 67);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 0;
            this.p6.TabStop = false;
            // 
            // p5
            // 
            this.p5.Image = ((System.Drawing.Image)(resources.GetObject("p5.Image")));
            this.p5.Location = new System.Drawing.Point(228, 116);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(63, 67);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 0;
            this.p5.TabStop = false;
            // 
            // p4
            // 
            this.p4.Image = ((System.Drawing.Image)(resources.GetObject("p4.Image")));
            this.p4.Location = new System.Drawing.Point(189, 43);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(63, 67);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 0;
            this.p4.TabStop = false;
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(120, 7);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(63, 67);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 0;
            this.p3.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(51, 43);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(63, 67);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(9, 116);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(63, 67);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Equivocaciones";
            // 
            // tEquivocaciones
            // 
            this.tEquivocaciones.Location = new System.Drawing.Point(646, 260);
            this.tEquivocaciones.Multiline = true;
            this.tEquivocaciones.Name = "tEquivocaciones";
            this.tEquivocaciones.Size = new System.Drawing.Size(53, 30);
            this.tEquivocaciones.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Puntos";
            // 
            // tPuntos
            // 
            this.tPuntos.Location = new System.Drawing.Point(401, 260);
            this.tPuntos.Multiline = true;
            this.tPuntos.Name = "tPuntos";
            this.tPuntos.Size = new System.Drawing.Size(53, 30);
            this.tPuntos.TabIndex = 31;
            // 
            // tPregunta
            // 
            this.tPregunta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tPregunta.Location = new System.Drawing.Point(323, 52);
            this.tPregunta.Name = "tPregunta";
            this.tPregunta.Size = new System.Drawing.Size(376, 19);
            this.tPregunta.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(417, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(201, 136);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fifth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tEquivocaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tPuntos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pTiempo);
            this.Controls.Add(this.lSetRespuestas);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.label1);
            this.Name = "Fifth";
            this.ShowIcon = false;
            this.Text = "Quinto Grado";
            this.Load += new System.EventHandler(this.Fifth_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pTiempo;
        private System.Windows.Forms.ListBox lSetRespuestas;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Timer tRuleta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEquivocaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPuntos;
        private System.Windows.Forms.TextBox tPregunta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}