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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.textBox2 = new NavyBeats_C_.Controles.TextBox();
            this.botonRedondoLogin = new NavyBeats_C_.Controles.BotonRedondo();
            this.textBox1 = new NavyBeats_C_.Controles.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelContra);
            this.panel.Controls.Add(this.labelCorreo);
            this.panel.Controls.Add(this.pictureBoxNombre);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.botonRedondoLogin);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Location = new System.Drawing.Point(217, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(850, 650);
            this.panel.TabIndex = 2;
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
            // pictureBoxNombre
            // 
            this.pictureBoxNombre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNombre.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Nombre;
            this.pictureBoxNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNombre.Location = new System.Drawing.Point(191, 186);
            this.pictureBoxNombre.Name = "pictureBoxNombre";
            this.pictureBoxNombre.Size = new System.Drawing.Size(450, 120);
            this.pictureBoxNombre.TabIndex = 4;
            this.pictureBoxNombre.TabStop = false;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.Transparent;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelCorreo.Location = new System.Drawing.Point(205, 349);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(72, 25);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.BackColor = System.Drawing.Color.Transparent;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.labelContra.Location = new System.Drawing.Point(204, 435);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(114, 25);
            this.labelContra.TabIndex = 6;
            this.labelContra.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBox2.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBox2.BorderRadius = 15;
            this.textBox2.BorderSize = 2;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBox2.Location = new System.Drawing.Point(191, 376);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(10);
            this.textBox2.Size = new System.Drawing.Size(450, 40);
            this.textBox2.TabIndex = 2;
            // 
            // botonRedondoLogin
            // 
            this.botonRedondoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoLogin.BorderRadius = 20;
            this.botonRedondoLogin.FlatAppearance.BorderSize = 0;
            this.botonRedondoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoLogin.Location = new System.Drawing.Point(320, 551);
            this.botonRedondoLogin.Name = "botonRedondoLogin";
            this.botonRedondoLogin.Size = new System.Drawing.Size(200, 50);
            this.botonRedondoLogin.TabIndex = 1;
            this.botonRedondoLogin.Text = "Entrar";
            this.botonRedondoLogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBox1.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBox1.BorderRadius = 15;
            this.textBox1.BorderSize = 2;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBox1.Location = new System.Drawing.Point(191, 462);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(10);
            this.textBox1.Size = new System.Drawing.Size(450, 40);
            this.textBox1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Controles.TextBox textBox2;
        private Controles.BotonRedondo botonRedondoLogin;
        private Controles.TextBox textBox1;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelContra;
    }
}