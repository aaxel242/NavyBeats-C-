namespace NavyBeats_C_
{
    partial class FormSoporte
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
            this.panelSoporte = new System.Windows.Forms.Panel();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoporte
            // 
            this.panelSoporte.Controls.Add(this.panelFormulario);
            this.panelSoporte.Controls.Add(this.pictureBox1);
            this.panelSoporte.Controls.Add(this.pboxAtras);
            this.panelSoporte.Location = new System.Drawing.Point(28, 29);
            this.panelSoporte.Name = "panelSoporte";
            this.panelSoporte.Size = new System.Drawing.Size(1225, 650);
            this.panelSoporte.TabIndex = 0;
            // 
            // pboxAtras
            // 
            this.pboxAtras.Image = global::NavyBeats_C_.Properties.Resources.imgAtras;
            this.pboxAtras.Location = new System.Drawing.Point(12, 13);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
            this.pboxAtras.TabIndex = 2;
            this.pboxAtras.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1152, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panelFormulario.Location = new System.Drawing.Point(324, 42);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(599, 573);
            this.panelFormulario.TabIndex = 4;
            // 
            // FormSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelSoporte);
            this.DoubleBuffered = true;
            this.Name = "FormSoporte";
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.FormSoporte_Load);
            this.panelSoporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoporte;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFormulario;
    }
}