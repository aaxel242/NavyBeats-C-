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
            this.textBoxContra = new NavyBeats_C_.Controles.TextBox();
            this.textBoxNombre = new NavyBeats_C_.Controles.TextBox();
            this.botonRedondoIniciar = new NavyBeats_C_.Controles.BotonRedondo();
            this.pictureBoxLogoName = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelContra);
            this.panel.Controls.Add(this.labelNombre);
            this.panel.Controls.Add(this.textBoxContra);
            this.panel.Controls.Add(this.textBoxNombre);
            this.panel.Controls.Add(this.botonRedondoIniciar);
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
            this.textBoxContra.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxContra.BorderRadius = 13;
            this.textBoxContra.BorderSize = 2;
            this.textBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.Location = new System.Drawing.Point(152, 457);
            this.textBoxContra.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxContra.Multiline = false;
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxContra.Size = new System.Drawing.Size(550, 40);
            this.textBoxContra.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxNombre.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxNombre.BorderRadius = 13;
            this.textBoxNombre.BorderSize = 2;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxNombre.Location = new System.Drawing.Point(152, 372);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxNombre.Multiline = false;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxNombre.Size = new System.Drawing.Size(550, 40);
            this.textBoxNombre.TabIndex = 10;
            // 
            // botonRedondoIniciar
            // 
            this.botonRedondoIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoIniciar.BorderRadius = 30;
            this.botonRedondoIniciar.FlatAppearance.BorderSize = 0;
            this.botonRedondoIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoIniciar.Location = new System.Drawing.Point(332, 532);
            this.botonRedondoIniciar.Name = "botonRedondoIniciar";
            this.botonRedondoIniciar.Size = new System.Drawing.Size(200, 50);
            this.botonRedondoIniciar.TabIndex = 5;
            this.botonRedondoIniciar.Text = "Iniciar";
            this.botonRedondoIniciar.UseVisualStyleBackColor = false;
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(364, 33);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(159, 345);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(159, 430);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(120, 25);
            this.labelContra.TabIndex = 13;
            this.labelContra.Text = "Contraseña:";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private Controles.BotonRedondo botonRedondoIniciar;
        private Controles.TextBox textBoxContra;
        private Controles.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Label labelNombre;
    }
}

