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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.panelIdiomas = new System.Windows.Forms.Panel();
            this.lblIdiomas = new System.Windows.Forms.Label();
            this.panelIngles = new System.Windows.Forms.Panel();
            this.panelEspañol = new System.Windows.Forms.Panel();
            this.panelCatalan = new System.Windows.Forms.Panel();
            this.lblCatala = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEspañol = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            this.panelIdiomas.SuspendLayout();
            this.panelIngles.SuspendLayout();
            this.panelEspañol.SuspendLayout();
            this.panelCatalan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1153, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panelIdiomas.Controls.Add(this.pictureBox1);
            this.panelIdiomas.Location = new System.Drawing.Point(30, 30);
            this.panelIdiomas.Name = "panelIdiomas";
            this.panelIdiomas.Size = new System.Drawing.Size(1225, 650);
            this.panelIdiomas.TabIndex = 1;
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
            // panelIngles
            // 
            this.panelIngles.BackColor = System.Drawing.Color.Transparent;
            this.panelIngles.Controls.Add(this.lblEnglish);
            this.panelIngles.Controls.Add(this.pictureBox4);
            this.panelIngles.Location = new System.Drawing.Point(753, 196);
            this.panelIngles.Name = "panelIngles";
            this.panelIngles.Size = new System.Drawing.Size(261, 253);
            this.panelIngles.TabIndex = 24;
            // 
            // panelEspañol
            // 
            this.panelEspañol.BackColor = System.Drawing.Color.Transparent;
            this.panelEspañol.Controls.Add(this.lblEspañol);
            this.panelEspañol.Controls.Add(this.pictureBox3);
            this.panelEspañol.Location = new System.Drawing.Point(460, 196);
            this.panelEspañol.Name = "panelEspañol";
            this.panelEspañol.Size = new System.Drawing.Size(261, 253);
            this.panelEspañol.TabIndex = 23;
            // 
            // panelCatalan
            // 
            this.panelCatalan.BackColor = System.Drawing.Color.Transparent;
            this.panelCatalan.Controls.Add(this.lblCatala);
            this.panelCatalan.Controls.Add(this.pictureBox2);
            this.panelCatalan.Location = new System.Drawing.Point(177, 196);
            this.panelCatalan.Name = "panelCatalan";
            this.panelCatalan.Size = new System.Drawing.Size(261, 253);
            this.panelCatalan.TabIndex = 22;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::NavyBeats_C_.Properties.Resources.imgCatalan;
            this.pictureBox2.Location = new System.Drawing.Point(47, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::NavyBeats_C_.Properties.Resources.imgEspañol;
            this.pictureBox3.Location = new System.Drawing.Point(47, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::NavyBeats_C_.Properties.Resources.imgIngles;
            this.pictureBox4.Location = new System.Drawing.Point(47, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 166);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
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
            this.Text = "FormIdiomas";
            this.Load += new System.EventHandler(this.FormIdiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            this.panelIdiomas.ResumeLayout(false);
            this.panelIdiomas.PerformLayout();
            this.panelIngles.ResumeLayout(false);
            this.panelIngles.PerformLayout();
            this.panelEspañol.ResumeLayout(false);
            this.panelEspañol.PerformLayout();
            this.panelCatalan.ResumeLayout(false);
            this.panelCatalan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.Panel panelIdiomas;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Panel panelIngles;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelEspañol;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelCatalan;
        private System.Windows.Forms.Label lblCatala;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}