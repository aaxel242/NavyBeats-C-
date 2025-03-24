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
            this.panelArtista = new System.Windows.Forms.Panel();
            this.labelArtista = new System.Windows.Forms.Label();
            this.pictureBoxArtista = new System.Windows.Forms.PictureBox();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panelArtista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            this.panelLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.panelArtista);
            this.panel.Controls.Add(this.pboxAtras);
            this.panel.Controls.Add(this.panelLocal);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.panelSistema);
            this.panel.Location = new System.Drawing.Point(30, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1225, 650);
            this.panel.TabIndex = 1;
            // 
            // panelArtista
            // 
            this.panelArtista.BackColor = System.Drawing.Color.Transparent;
            this.panelArtista.Controls.Add(this.labelArtista);
            this.panelArtista.Controls.Add(this.pictureBoxArtista);
            this.panelArtista.Location = new System.Drawing.Point(751, 218);
            this.panelArtista.Name = "panelArtista";
            this.panelArtista.Size = new System.Drawing.Size(261, 253);
            this.panelArtista.TabIndex = 24;
            this.panelArtista.Click += new System.EventHandler(this.panel_Click);
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.BackColor = System.Drawing.Color.Transparent;
            this.labelArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelArtista.Location = new System.Drawing.Point(94, 208);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(74, 25);
            this.labelArtista.TabIndex = 36;
            this.labelArtista.Text = "Artista";
            // 
            // pictureBoxArtista
            // 
            this.pictureBoxArtista.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArtista.BackgroundImage = global::NavyBeats_C_.Properties.Resources.imgArtista;
            this.pictureBoxArtista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxArtista.Location = new System.Drawing.Point(47, 20);
            this.pictureBoxArtista.Name = "pictureBoxArtista";
            this.pictureBoxArtista.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxArtista.TabIndex = 35;
            this.pictureBoxArtista.TabStop = false;
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = global::NavyBeats_C_.Properties.Resources.imgAtras;
            this.pboxAtras.Location = new System.Drawing.Point(18, 20);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
            this.pboxAtras.TabIndex = 8;
            this.pboxAtras.TabStop = false;
            this.pboxAtras.Click += new System.EventHandler(this.pboxAtras_Click);
            // 
            // panelLocal
            // 
            this.panelLocal.BackColor = System.Drawing.Color.Transparent;
            this.panelLocal.Controls.Add(this.pictureBox1);
            this.panelLocal.Controls.Add(this.labelLocal);
            this.panelLocal.Location = new System.Drawing.Point(458, 218);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(261, 253);
            this.panelLocal.TabIndex = 23;
            this.panelLocal.Click += new System.EventHandler(this.panel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::NavyBeats_C_.Properties.Resources.imgLocal;
            this.pictureBox1.Location = new System.Drawing.Point(47, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.BackColor = System.Drawing.Color.Transparent;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelLocal.Location = new System.Drawing.Point(93, 208);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(64, 25);
            this.labelLocal.TabIndex = 31;
            this.labelLocal.Text = "Local";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(1149, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panelSistema
            // 
            this.panelSistema.BackColor = System.Drawing.Color.Transparent;
            this.panelSistema.Controls.Add(this.pictureBoxUsuario);
            this.panelSistema.Controls.Add(this.labelUsuario);
            this.panelSistema.Location = new System.Drawing.Point(175, 218);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(261, 253);
            this.panelSistema.TabIndex = 22;
            this.panelSistema.Click += new System.EventHandler(this.panel_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuario.BackgroundImage = global::NavyBeats_C_.Properties.Resources.imgGestionUsuario;
            this.pictureBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(43, 20);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxUsuario.TabIndex = 34;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelUsuario.Location = new System.Drawing.Point(22, 208);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(216, 25);
            this.labelUsuario.TabIndex = 35;
            this.labelUsuario.Text = "Usuarios del Sistema";
            // 
            // FormMenuGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenuGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGestion";
            this.Load += new System.EventHandler(this.FormMenuGestion_Load);
            this.panel.ResumeLayout(false);
            this.panelArtista.ResumeLayout(false);
            this.panelArtista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            this.panelLocal.ResumeLayout(false);
            this.panelLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSistema.ResumeLayout(false);
            this.panelSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelArtista;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.PictureBox pictureBoxArtista;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
    }
}