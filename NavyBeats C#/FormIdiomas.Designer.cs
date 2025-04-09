namespace NavyBeats_C_
{
    partial class FormIdiomas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIdiomas));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.panelIdiomas = new System.Windows.Forms.Panel();
            this.panelIngles = new System.Windows.Forms.Panel();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.pictureBoxIngles = new System.Windows.Forms.PictureBox();
            this.panelEspañol = new System.Windows.Forms.Panel();
            this.lblEspañol = new System.Windows.Forms.Label();
            this.pictureBoxEspañol = new System.Windows.Forms.PictureBox();
            this.panelCatalan = new System.Windows.Forms.Panel();
            this.lblCatala = new System.Windows.Forms.Label();
            this.pictureBoxCatalan = new System.Windows.Forms.PictureBox();
            this.lblIdiomas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            this.panelIdiomas.SuspendLayout();
            this.panelIngles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngles)).BeginInit();
            this.panelEspañol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspañol)).BeginInit();
            this.panelCatalan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1153, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = ((System.Drawing.Image)(resources.GetObject("pboxAtras.Image")));
            this.pboxAtras.Location = new System.Drawing.Point(22, 13);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
            this.pboxAtras.TabIndex = 1;
            this.pboxAtras.TabStop = false;
            this.pboxAtras.Click += new System.EventHandler(this.pboxAtras_Click);
            // 
            // panelIdiomas
            // 
            this.panelIdiomas.BackColor = System.Drawing.Color.White;
            this.panelIdiomas.Controls.Add(this.panelIngles);
            this.panelIdiomas.Controls.Add(this.panelEspañol);
            this.panelIdiomas.Controls.Add(this.panelCatalan);
            this.panelIdiomas.Controls.Add(this.lblIdiomas);
            this.panelIdiomas.Controls.Add(this.pboxAtras);
            this.panelIdiomas.Controls.Add(this.pictureBoxLogo);
            this.panelIdiomas.Location = new System.Drawing.Point(30, 30);
            this.panelIdiomas.Name = "panelIdiomas";
            this.panelIdiomas.Size = new System.Drawing.Size(1225, 650);
            this.panelIdiomas.TabIndex = 1;
            // 
            // panelIngles
            // 
            this.panelIngles.BackColor = System.Drawing.Color.Transparent;
            this.panelIngles.Controls.Add(this.lblEnglish);
            this.panelIngles.Controls.Add(this.pictureBoxIngles);
            this.panelIngles.Location = new System.Drawing.Point(753, 196);
            this.panelIngles.Name = "panelIngles";
            this.panelIngles.Size = new System.Drawing.Size(261, 253);
            this.panelIngles.TabIndex = 24;
            this.panelIngles.Click += new System.EventHandler(this.panel_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.BackColor = System.Drawing.Color.Transparent;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.lblEnglish.Location = new System.Drawing.Point(84, 204);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(80, 24);
            this.lblEnglish.TabIndex = 20;
            this.lblEnglish.Text = "English";
            // 
            // pictureBoxIngles
            // 
            this.pictureBoxIngles.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIngles.Image = global::NavyBeats_C_.Properties.Resources.imgIngles;
            this.pictureBoxIngles.Location = new System.Drawing.Point(47, 25);
            this.pictureBoxIngles.Name = "pictureBoxIngles";
            this.pictureBoxIngles.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIngles.TabIndex = 19;
            this.pictureBoxIngles.TabStop = false;
            // 
            // panelEspañol
            // 
            this.panelEspañol.BackColor = System.Drawing.Color.Transparent;
            this.panelEspañol.Controls.Add(this.lblEspañol);
            this.panelEspañol.Controls.Add(this.pictureBoxEspañol);
            this.panelEspañol.Location = new System.Drawing.Point(460, 196);
            this.panelEspañol.Name = "panelEspañol";
            this.panelEspañol.Size = new System.Drawing.Size(261, 253);
            this.panelEspañol.TabIndex = 23;
            this.panelEspañol.Click += new System.EventHandler(this.panel_Click);
            // 
            // lblEspañol
            // 
            this.lblEspañol.AutoSize = true;
            this.lblEspañol.BackColor = System.Drawing.Color.Transparent;
            this.lblEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspañol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.lblEspañol.Location = new System.Drawing.Point(83, 204);
            this.lblEspañol.Name = "lblEspañol";
            this.lblEspañol.Size = new System.Drawing.Size(86, 24);
            this.lblEspañol.TabIndex = 19;
            this.lblEspañol.Text = "Español";
            // 
            // pictureBoxEspañol
            // 
            this.pictureBoxEspañol.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEspañol.Image = global::NavyBeats_C_.Properties.Resources.imgEspañol;
            this.pictureBoxEspañol.Location = new System.Drawing.Point(47, 25);
            this.pictureBoxEspañol.Name = "pictureBoxEspañol";
            this.pictureBoxEspañol.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxEspañol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEspañol.TabIndex = 18;
            this.pictureBoxEspañol.TabStop = false;
            // 
            // panelCatalan
            // 
            this.panelCatalan.BackColor = System.Drawing.Color.Transparent;
            this.panelCatalan.Controls.Add(this.lblCatala);
            this.panelCatalan.Controls.Add(this.pictureBoxCatalan);
            this.panelCatalan.Location = new System.Drawing.Point(177, 196);
            this.panelCatalan.Name = "panelCatalan";
            this.panelCatalan.Size = new System.Drawing.Size(261, 253);
            this.panelCatalan.TabIndex = 22;
            this.panelCatalan.Click += new System.EventHandler(this.panel_Click);
            // 
            // lblCatala
            // 
            this.lblCatala.AutoSize = true;
            this.lblCatala.BackColor = System.Drawing.Color.Transparent;
            this.lblCatala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.lblCatala.Location = new System.Drawing.Point(89, 204);
            this.lblCatala.Name = "lblCatala";
            this.lblCatala.Size = new System.Drawing.Size(67, 24);
            this.lblCatala.TabIndex = 18;
            this.lblCatala.Text = "Català";
            // 
            // pictureBoxCatalan
            // 
            this.pictureBoxCatalan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCatalan.Image = global::NavyBeats_C_.Properties.Resources.imgCatalan;
            this.pictureBoxCatalan.Location = new System.Drawing.Point(47, 25);
            this.pictureBoxCatalan.Name = "pictureBoxCatalan";
            this.pictureBoxCatalan.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxCatalan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCatalan.TabIndex = 17;
            this.pictureBoxCatalan.TabStop = false;
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.BackColor = System.Drawing.Color.Transparent;
            this.lblIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.lblIdiomas.Location = new System.Drawing.Point(470, 67);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(264, 29);
            this.lblIdiomas.TabIndex = 12;
            this.lblIdiomas.Text = "Selecciona un Idioma";
            // 
            // FormIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelIdiomas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormIdiomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIdiomas";
            this.Load += new System.EventHandler(this.FormIdiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            this.panelIdiomas.ResumeLayout(false);
            this.panelIdiomas.PerformLayout();
            this.panelIngles.ResumeLayout(false);
            this.panelIngles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngles)).EndInit();
            this.panelEspañol.ResumeLayout(false);
            this.panelEspañol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspañol)).EndInit();
            this.panelCatalan.ResumeLayout(false);
            this.panelCatalan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.Panel panelIdiomas;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Panel panelIngles;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.PictureBox pictureBoxIngles;
        private System.Windows.Forms.Panel panelEspañol;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.PictureBox pictureBoxEspañol;
        private System.Windows.Forms.Panel panelCatalan;
        private System.Windows.Forms.Label lblCatala;
        private System.Windows.Forms.PictureBox pictureBoxCatalan;
    }
}