namespace NavyBeats_C_
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.pictureBoxLogoName = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.botonRedondoIniciar = new NavyBeats_C_.Controles.BotonRedondo();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.botonRedondoIniciar);
            this.panel.Controls.Add(this.textBoxContra);
            this.panel.Controls.Add(this.textBoxNombre);
            this.panel.Controls.Add(this.pictureBoxLogoName);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Location = new System.Drawing.Point(217, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 650);
            this.panel.TabIndex = 0;
            // 
            // textBoxContra
            // 
            this.textBoxContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.Location = new System.Drawing.Point(152, 454);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.PasswordChar = '*';
            this.textBoxContra.Size = new System.Drawing.Size(550, 13);
            this.textBoxContra.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxNombre.Location = new System.Drawing.Point(152, 405);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(550, 13);
            this.textBoxNombre.TabIndex = 2;
            // 
            // pictureBoxLogoName
            // 
            this.pictureBoxLogoName.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoName.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Nombre;
            this.pictureBoxLogoName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogoName.Location = new System.Drawing.Point(188, 179);
            this.pictureBoxLogoName.Name = "pictureBoxLogoName";
            this.pictureBoxLogoName.Size = new System.Drawing.Size(500, 150);
            this.pictureBoxLogoName.TabIndex = 1;
            this.pictureBoxLogoName.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(365, 33);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // botonRedondoIniciar
            // 
            this.botonRedondoIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoIniciar.FlatAppearance.BorderSize = 0;
            this.botonRedondoIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoIniciar.Location = new System.Drawing.Point(332, 529);
            this.botonRedondoIniciar.Name = "botonRedondoIniciar";
            this.botonRedondoIniciar.Size = new System.Drawing.Size(200, 50);
            this.botonRedondoIniciar.TabIndex = 5;
            this.botonRedondoIniciar.Text = "Iniciar";
            this.botonRedondoIniciar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogoName;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.TextBox textBoxNombre;
        private Controles.BotonRedondo botonRedondoIniciar;
    }
}

