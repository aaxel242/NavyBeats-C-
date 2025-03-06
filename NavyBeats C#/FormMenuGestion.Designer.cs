namespace NavyBeats_C_
{
    partial class FormMenuGestion
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
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArtista = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelArtista = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelArtista);
            this.panel.Controls.Add(this.labelLocal);
            this.panel.Controls.Add(this.labelUsuario);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.pictureBoxArtista);
            this.panel.Controls.Add(this.pictureBoxUsuario);
            this.panel.Location = new System.Drawing.Point(217, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 650);
            this.panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(352, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxArtista
            // 
            this.pictureBoxArtista.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArtista.BackgroundImage = global::NavyBeats_C_.Properties.Resources.imgArtista;
            this.pictureBoxArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxArtista.Location = new System.Drawing.Point(582, 240);
            this.pictureBoxArtista.Name = "pictureBoxArtista";
            this.pictureBoxArtista.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxArtista.TabIndex = 1;
            this.pictureBoxArtista.TabStop = false;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuario.BackgroundImage = global::NavyBeats_C_.Properties.Resources.imgGestionUsuario;
            this.pictureBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(120, 240);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxUsuario.TabIndex = 0;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelUsuario.Location = new System.Drawing.Point(88, 404);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(196, 25);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuarios del Sistema";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelLocal.Location = new System.Drawing.Point(388, 404);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(59, 25);
            this.labelLocal.TabIndex = 5;
            this.labelLocal.Text = "Local";
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelArtista.Location = new System.Drawing.Point(616, 404);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(67, 25);
            this.labelArtista.TabIndex = 6;
            this.labelArtista.Text = "Artista";
            // 
            // MenuGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel);
            this.Name = "MenuGestion";
            this.Text = "MenuGestion";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxArtista;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelArtista;
    }
}