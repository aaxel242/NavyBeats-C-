namespace NavyBeats_C_
{
    partial class FormLocalMusicoSA
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
            this.panelAzul = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBlanco = new System.Windows.Forms.Panel();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.botonRedondoEliminar = new NavyBeats_C_.Controles.BotonRedondo();
            this.botonRedondoCrear = new NavyBeats_C_.Controles.BotonRedondo();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBlanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAzul
            // 
            this.panelAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelAzul.Controls.Add(this.pictureBox1);
            this.panelAzul.Controls.Add(this.botonRedondoEliminar);
            this.panelAzul.Controls.Add(this.botonRedondoCrear);
            this.panelAzul.Location = new System.Drawing.Point(30, 30);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(306, 650);
            this.panelAzul.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NavyBeats_C_.Properties.Resources.imgSalirDorado;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelBlanco
            // 
            this.panelBlanco.BackColor = System.Drawing.Color.White;
            this.panelBlanco.Controls.Add(this.pictureBoxNombre);
            this.panelBlanco.Controls.Add(this.pictureBoxLogo);
            this.panelBlanco.Location = new System.Drawing.Point(335, 30);
            this.panelBlanco.Name = "panelBlanco";
            this.panelBlanco.Size = new System.Drawing.Size(920, 650);
            this.panelBlanco.TabIndex = 9;
            // 
            // pictureBoxNombre
            // 
            this.pictureBoxNombre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNombre.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Nombre;
            this.pictureBoxNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNombre.Location = new System.Drawing.Point(229, 16);
            this.pictureBoxNombre.Name = "pictureBoxNombre";
            this.pictureBoxNombre.Size = new System.Drawing.Size(350, 100);
            this.pictureBoxNombre.TabIndex = 10;
            this.pictureBoxNombre.TabStop = false;
            // 
            // botonRedondoEliminar
            // 
            this.botonRedondoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoEliminar.BorderRadius = 20;
            this.botonRedondoEliminar.FlatAppearance.BorderSize = 0;
            this.botonRedondoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoEliminar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoEliminar.Location = new System.Drawing.Point(81, 372);
            this.botonRedondoEliminar.Name = "botonRedondoEliminar";
            this.botonRedondoEliminar.Size = new System.Drawing.Size(150, 40);
            this.botonRedondoEliminar.TabIndex = 9;
            this.botonRedondoEliminar.Text = "Eliminar";
            this.botonRedondoEliminar.UseVisualStyleBackColor = false;
            // 
            // botonRedondoCrear
            // 
            this.botonRedondoCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoCrear.BorderRadius = 20;
            this.botonRedondoCrear.FlatAppearance.BorderSize = 0;
            this.botonRedondoCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoCrear.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoCrear.Location = new System.Drawing.Point(81, 257);
            this.botonRedondoCrear.Name = "botonRedondoCrear";
            this.botonRedondoCrear.Size = new System.Drawing.Size(150, 40);
            this.botonRedondoCrear.TabIndex = 8;
            this.botonRedondoCrear.Text = "Crear";
            this.botonRedondoCrear.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(835, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormLocalMusico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelAzul);
            this.Controls.Add(this.panelBlanco);
            this.Name = "FormLocalMusico";
            this.Text = "FormLocalMusico";
            this.panelAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBlanco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles.BotonRedondo botonRedondoEliminar;
        private Controles.BotonRedondo botonRedondoCrear;
        private System.Windows.Forms.Panel panelBlanco;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}