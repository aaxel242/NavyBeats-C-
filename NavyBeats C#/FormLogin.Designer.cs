namespace NavyBeats_C_
{
    partial class FormLogin
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
            this.labelContra = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxIngles = new System.Windows.Forms.PictureBox();
            this.pictureBoxEspañol = new System.Windows.Forms.PictureBox();
            this.pictureBoxCatalan = new System.Windows.Forms.PictureBox();
            this.textBoxContra = new NavyBeats_C_.Controles.TextBox();
            this.textBoxCorreo = new NavyBeats_C_.Controles.TextBox();
            this.customBotonLogin = new NavyBeats_C_.Controles.CustomBoton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspañol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBoxIngles);
            this.panel.Controls.Add(this.pictureBoxEspañol);
            this.panel.Controls.Add(this.textBoxContra);
            this.panel.Controls.Add(this.pictureBoxCatalan);
            this.panel.Controls.Add(this.textBoxCorreo);
            this.panel.Controls.Add(this.labelContra);
            this.panel.Controls.Add(this.labelCorreo);
            this.panel.Controls.Add(this.pictureBoxNombre);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Controls.Add(this.customBotonLogin);
            this.panel.Location = new System.Drawing.Point(217, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 650);
            this.panel.TabIndex = 2;
            // 
            // labelContra
            // 
            this.labelContra.BackColor = System.Drawing.Color.Transparent;
            this.labelContra.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelContra.Location = new System.Drawing.Point(202, 435);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(168, 26);
            this.labelContra.TabIndex = 6;
            this.labelContra.Text = "Contraseña:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.BackColor = System.Drawing.Color.Transparent;
            this.labelCorreo.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelCorreo.Location = new System.Drawing.Point(203, 348);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(90, 27);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo:";
            // 
            // pictureBoxNombre
            // 
            this.pictureBoxNombre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNombre.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Nombre;
            this.pictureBoxNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNombre.Location = new System.Drawing.Point(219, 186);
            this.pictureBoxNombre.Name = "pictureBoxNombre";
            this.pictureBoxNombre.Size = new System.Drawing.Size(400, 120);
            this.pictureBoxNombre.TabIndex = 4;
            this.pictureBoxNombre.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(343, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxIngles
            // 
            this.pictureBoxIngles.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIngles.Image = global::NavyBeats_C_.Properties.Resources.imgIngles;
            this.pictureBoxIngles.Location = new System.Drawing.Point(125, 13);
            this.pictureBoxIngles.Name = "pictureBoxIngles";
            this.pictureBoxIngles.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIngles.TabIndex = 22;
            this.pictureBoxIngles.TabStop = false;
            this.pictureBoxIngles.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBoxEspañol
            // 
            this.pictureBoxEspañol.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEspañol.Image = global::NavyBeats_C_.Properties.Resources.imgEspañol;
            this.pictureBoxEspañol.Location = new System.Drawing.Point(69, 13);
            this.pictureBoxEspañol.Name = "pictureBoxEspañol";
            this.pictureBoxEspañol.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEspañol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEspañol.TabIndex = 21;
            this.pictureBoxEspañol.TabStop = false;
            this.pictureBoxEspañol.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBoxCatalan
            // 
            this.pictureBoxCatalan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCatalan.Image = global::NavyBeats_C_.Properties.Resources.imgCatalan;
            this.pictureBoxCatalan.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCatalan.Name = "pictureBoxCatalan";
            this.pictureBoxCatalan.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCatalan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCatalan.TabIndex = 20;
            this.pictureBoxCatalan.TabStop = false;
            this.pictureBoxCatalan.Click += new System.EventHandler(this.imageClick);
            // 
            // textBoxContra
            // 
            this.textBoxContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxContra.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxContra.BorderRadius = 15;
            this.textBoxContra.BorderSize = 2;
            this.textBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.Location = new System.Drawing.Point(191, 462);
            this.textBoxContra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxContra.Multiline = false;
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxContra.PasswordChar = true;
            this.textBoxContra.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.PlaceholderText = "";
            this.textBoxContra.Size = new System.Drawing.Size(450, 42);
            this.textBoxContra.TabIndex = 10;
            this.textBoxContra.Texts = "";
            this.textBoxContra.UnderlinedStyle = false;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxCorreo.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxCorreo.BorderRadius = 15;
            this.textBoxCorreo.BorderSize = 2;
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxCorreo.Location = new System.Drawing.Point(191, 376);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCorreo.Multiline = false;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxCorreo.PasswordChar = false;
            this.textBoxCorreo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxCorreo.PlaceholderText = "";
            this.textBoxCorreo.Size = new System.Drawing.Size(450, 42);
            this.textBoxCorreo.TabIndex = 9;
            this.textBoxCorreo.Texts = "";
            this.textBoxCorreo.UnderlinedStyle = false;
            // 
            // customBotonLogin
            // 
            this.customBotonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.customBotonLogin.BorderRadius = 20;
            this.customBotonLogin.FlatAppearance.BorderSize = 0;
            this.customBotonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBotonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBotonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customBotonLogin.Location = new System.Drawing.Point(320, 551);
            this.customBotonLogin.Name = "customBotonLogin";
            this.customBotonLogin.Size = new System.Drawing.Size(200, 50);
            this.customBotonLogin.TabIndex = 1;
            this.customBotonLogin.Text = "Entrar";
            this.customBotonLogin.UseVisualStyleBackColor = false;
            this.customBotonLogin.Click += new System.EventHandler(this.botonRedondoLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspañol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Controles.CustomBoton customBotonLogin;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelContra;
        private Controles.TextBox textBoxCorreo;
        private Controles.TextBox textBoxContra;
        private System.Windows.Forms.PictureBox pictureBoxIngles;
        private System.Windows.Forms.PictureBox pictureBoxEspañol;
        private System.Windows.Forms.PictureBox pictureBoxCatalan;
    }
}