namespace Aprende_con_Geo_Preguntas
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            this.pTercero = new System.Windows.Forms.PictureBox();
            this.pCuarto = new System.Windows.Forms.PictureBox();
            this.pQuinto = new System.Windows.Forms.PictureBox();
            this.pSexto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pTercero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQuinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSexto)).BeginInit();
            this.SuspendLayout();
            // 
            // pTercero
            // 
            this.pTercero.Image = ((System.Drawing.Image)(resources.GetObject("pTercero.Image")));
            this.pTercero.Location = new System.Drawing.Point(25, 50);
            this.pTercero.Name = "pTercero";
            this.pTercero.Size = new System.Drawing.Size(172, 128);
            this.pTercero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTercero.TabIndex = 0;
            this.pTercero.TabStop = false;
            this.pTercero.Click += new System.EventHandler(this.pTercero_Click);
            // 
            // pCuarto
            // 
            this.pCuarto.Image = ((System.Drawing.Image)(resources.GetObject("pCuarto.Image")));
            this.pCuarto.Location = new System.Drawing.Point(217, 50);
            this.pCuarto.Name = "pCuarto";
            this.pCuarto.Size = new System.Drawing.Size(172, 128);
            this.pCuarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pCuarto.TabIndex = 1;
            this.pCuarto.TabStop = false;
            this.pCuarto.Click += new System.EventHandler(this.pCuarto_Click);
            // 
            // pQuinto
            // 
            this.pQuinto.Image = ((System.Drawing.Image)(resources.GetObject("pQuinto.Image")));
            this.pQuinto.Location = new System.Drawing.Point(25, 185);
            this.pQuinto.Name = "pQuinto";
            this.pQuinto.Size = new System.Drawing.Size(172, 128);
            this.pQuinto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pQuinto.TabIndex = 2;
            this.pQuinto.TabStop = false;
            this.pQuinto.Click += new System.EventHandler(this.pQuinto_Click);
            // 
            // pSexto
            // 
            this.pSexto.Image = ((System.Drawing.Image)(resources.GetObject("pSexto.Image")));
            this.pSexto.Location = new System.Drawing.Point(217, 185);
            this.pSexto.Name = "pSexto";
            this.pSexto.Size = new System.Drawing.Size(172, 128);
            this.pSexto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSexto.TabIndex = 3;
            this.pSexto.TabStop = false;
            this.pSexto.Click += new System.EventHandler(this.pSexto_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el nivel";
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pSexto);
            this.Controls.Add(this.pQuinto);
            this.Controls.Add(this.pCuarto);
            this.Controls.Add(this.pTercero);
            this.Name = "Levels";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pTercero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQuinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSexto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pTercero;
        private System.Windows.Forms.PictureBox pCuarto;
        private System.Windows.Forms.PictureBox pQuinto;
        private System.Windows.Forms.PictureBox pSexto;
        private System.Windows.Forms.Label label1;
    }
}