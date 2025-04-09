namespace NavyBeats_C_
{
    partial class FormInfoMusico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoMusico));
            this.labelContra = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.labelConf = new System.Windows.Forms.Label();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.listBoxEstilos = new System.Windows.Forms.ListBox();
            this.labelEstilos = new System.Windows.Forms.Label();
            this.customComboBoxMunicipio = new NavyBeats_C_.Controles.CustomComboBox();
            this.textBoxConfirmar = new NavyBeats_C_.Controles.TextBox();
            this.textBoxTelefono = new NavyBeats_C_.Controles.TextBox();
            this.botonRedondoGuardar = new NavyBeats_C_.Controles.CustomBoton();
            this.textBoxContra = new NavyBeats_C_.Controles.TextBox();
            this.textBoxCorreo = new NavyBeats_C_.Controles.TextBox();
            this.textBoxNombre = new NavyBeats_C_.Controles.TextBox();
            this.textBoxLongitud = new NavyBeats_C_.Controles.TextBox();
            this.textBoxLatitud = new NavyBeats_C_.Controles.TextBox();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.labelLatitud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(20, 306);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(134, 31);
            this.labelContra.TabIndex = 28;
            this.labelContra.Text = "Contraseña";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(20, 247);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(85, 31);
            this.labelCorreo.TabIndex = 27;
            this.labelCorreo.Text = "Correo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(20, 182);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 31);
            this.labelNombre.TabIndex = 26;
            this.labelNombre.Text = "Nombre";
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = ((System.Drawing.Image)(resources.GetObject("pboxAtras.Image")));
            this.pboxAtras.Location = new System.Drawing.Point(27, 46);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
            this.pboxAtras.TabIndex = 35;
            this.pboxAtras.TabStop = false;
            this.pboxAtras.Click += new System.EventHandler(this.pboxAtras_Click);
            // 
            // pictureBoxNombre
            // 
            this.pictureBoxNombre.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNombre.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Nombre;
            this.pictureBoxNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNombre.Location = new System.Drawing.Point(299, 28);
            this.pictureBoxNombre.Name = "pictureBoxNombre";
            this.pictureBoxNombre.Size = new System.Drawing.Size(350, 100);
            this.pictureBoxNombre.TabIndex = 25;
            this.pictureBoxNombre.TabStop = false;
            // 
            // labelConf
            // 
            this.labelConf.AutoSize = true;
            this.labelConf.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConf.Location = new System.Drawing.Point(20, 367);
            this.labelConf.Name = "labelConf";
            this.labelConf.Size = new System.Drawing.Size(194, 31);
            this.labelConf.TabIndex = 38;
            this.labelConf.Text = "Conf. Contraseña";
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(498, 183);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(118, 31);
            this.labelMunicipio.TabIndex = 37;
            this.labelMunicipio.Text = "Municipio";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(20, 426);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(118, 31);
            this.labelTel.TabIndex = 36;
            this.labelTel.Text = "Teléfeono";
            // 
            // listBoxEstilos
            // 
            this.listBoxEstilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.listBoxEstilos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEstilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBoxEstilos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.listBoxEstilos.FormattingEnabled = true;
            this.listBoxEstilos.ItemHeight = 25;
            this.listBoxEstilos.Location = new System.Drawing.Point(693, 355);
            this.listBoxEstilos.Name = "listBoxEstilos";
            this.listBoxEstilos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEstilos.Size = new System.Drawing.Size(250, 100);
            this.listBoxEstilos.TabIndex = 44;
            // 
            // labelEstilos
            // 
            this.labelEstilos.AutoSize = true;
            this.labelEstilos.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstilos.Location = new System.Drawing.Point(498, 367);
            this.labelEstilos.Name = "labelEstilos";
            this.labelEstilos.Size = new System.Drawing.Size(83, 31);
            this.labelEstilos.TabIndex = 45;
            this.labelEstilos.Text = "Estilos";
            // 
            // customComboBoxMunicipio
            // 
            this.customComboBoxMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customComboBoxMunicipio.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customComboBoxMunicipio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.customComboBoxMunicipio.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.customComboBoxMunicipio.BorderSize = 2;
            this.customComboBoxMunicipio.BorderSize1 = 2;
            this.customComboBoxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.customComboBoxMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customComboBoxMunicipio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customComboBoxMunicipio.IconColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customComboBoxMunicipio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customComboBoxMunicipio.ListBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customComboBoxMunicipio.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customComboBoxMunicipio.ListTextColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customComboBoxMunicipio.Location = new System.Drawing.Point(693, 172);
            this.customComboBoxMunicipio.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBoxMunicipio.Name = "customComboBoxMunicipio";
            this.customComboBoxMunicipio.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBoxMunicipio.Size = new System.Drawing.Size(250, 42);
            this.customComboBoxMunicipio.TabIndex = 43;
            this.customComboBoxMunicipio.Texts = "";
            // 
            // textBoxConfirmar
            // 
            this.textBoxConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxConfirmar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxConfirmar.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxConfirmar.BorderRadius = 15;
            this.textBoxConfirmar.BorderSize = 2;
            this.textBoxConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxConfirmar.Location = new System.Drawing.Point(215, 355);
            this.textBoxConfirmar.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxConfirmar.Multiline = false;
            this.textBoxConfirmar.Name = "textBoxConfirmar";
            this.textBoxConfirmar.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxConfirmar.PasswordChar = true;
            this.textBoxConfirmar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxConfirmar.PlaceholderText = "";
            this.textBoxConfirmar.Size = new System.Drawing.Size(250, 46);
            this.textBoxConfirmar.TabIndex = 42;
            this.textBoxConfirmar.Texts = "";
            this.textBoxConfirmar.UnderlinedStyle = false;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxTelefono.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxTelefono.BorderRadius = 15;
            this.textBoxTelefono.BorderSize = 2;
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxTelefono.Location = new System.Drawing.Point(215, 416);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxTelefono.Multiline = false;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxTelefono.PasswordChar = false;
            this.textBoxTelefono.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxTelefono.PlaceholderText = "";
            this.textBoxTelefono.Size = new System.Drawing.Size(250, 46);
            this.textBoxTelefono.TabIndex = 40;
            this.textBoxTelefono.Texts = "";
            this.textBoxTelefono.UnderlinedStyle = false;
            // 
            // botonRedondoGuardar
            // 
            this.botonRedondoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoGuardar.BorderRadius = 20;
            this.botonRedondoGuardar.FlatAppearance.BorderSize = 0;
            this.botonRedondoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoGuardar.Location = new System.Drawing.Point(351, 518);
            this.botonRedondoGuardar.Name = "botonRedondoGuardar";
            this.botonRedondoGuardar.Size = new System.Drawing.Size(250, 46);
            this.botonRedondoGuardar.TabIndex = 34;
            this.botonRedondoGuardar.Text = "Guardar";
            this.botonRedondoGuardar.UseVisualStyleBackColor = false;
            this.botonRedondoGuardar.Click += new System.EventHandler(this.botonRedondoGuardar_Click);
            // 
            // textBoxContra
            // 
            this.textBoxContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxContra.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxContra.BorderRadius = 15;
            this.textBoxContra.BorderSize = 2;
            this.textBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.Location = new System.Drawing.Point(215, 294);
            this.textBoxContra.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxContra.Multiline = false;
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxContra.PasswordChar = true;
            this.textBoxContra.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxContra.PlaceholderText = "";
            this.textBoxContra.Size = new System.Drawing.Size(250, 46);
            this.textBoxContra.TabIndex = 32;
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
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxCorreo.Location = new System.Drawing.Point(215, 233);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxCorreo.Multiline = false;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxCorreo.PasswordChar = false;
            this.textBoxCorreo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxCorreo.PlaceholderText = "";
            this.textBoxCorreo.Size = new System.Drawing.Size(250, 46);
            this.textBoxCorreo.TabIndex = 31;
            this.textBoxCorreo.Texts = "";
            this.textBoxCorreo.UnderlinedStyle = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxNombre.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxNombre.BorderRadius = 15;
            this.textBoxNombre.BorderSize = 2;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxNombre.Location = new System.Drawing.Point(215, 172);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxNombre.Multiline = false;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxNombre.PasswordChar = false;
            this.textBoxNombre.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxNombre.PlaceholderText = "";
            this.textBoxNombre.Size = new System.Drawing.Size(250, 46);
            this.textBoxNombre.TabIndex = 30;
            this.textBoxNombre.Texts = "";
            this.textBoxNombre.UnderlinedStyle = false;
            // 
            // textBoxLongitud
            // 
            this.textBoxLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxLongitud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxLongitud.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxLongitud.BorderRadius = 15;
            this.textBoxLongitud.BorderSize = 2;
            this.textBoxLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxLongitud.Location = new System.Drawing.Point(693, 294);
            this.textBoxLongitud.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxLongitud.Multiline = false;
            this.textBoxLongitud.Name = "textBoxLongitud";
            this.textBoxLongitud.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxLongitud.PasswordChar = false;
            this.textBoxLongitud.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxLongitud.PlaceholderText = "";
            this.textBoxLongitud.Size = new System.Drawing.Size(250, 46);
            this.textBoxLongitud.TabIndex = 49;
            this.textBoxLongitud.Texts = "";
            this.textBoxLongitud.UnderlinedStyle = false;
            // 
            // textBoxLatitud
            // 
            this.textBoxLatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.textBoxLatitud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.textBoxLatitud.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxLatitud.BorderRadius = 15;
            this.textBoxLatitud.BorderSize = 2;
            this.textBoxLatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxLatitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxLatitud.Location = new System.Drawing.Point(693, 233);
            this.textBoxLatitud.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxLatitud.Multiline = false;
            this.textBoxLatitud.Name = "textBoxLatitud";
            this.textBoxLatitud.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxLatitud.PasswordChar = false;
            this.textBoxLatitud.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.textBoxLatitud.PlaceholderText = "";
            this.textBoxLatitud.Size = new System.Drawing.Size(250, 46);
            this.textBoxLatitud.TabIndex = 48;
            this.textBoxLatitud.Texts = "";
            this.textBoxLatitud.UnderlinedStyle = false;
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitud.Location = new System.Drawing.Point(498, 308);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(110, 31);
            this.labelLongitud.TabIndex = 47;
            this.labelLongitud.Text = "Longitud";
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatitud.Location = new System.Drawing.Point(498, 243);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(87, 31);
            this.labelLatitud.TabIndex = 46;
            this.labelLatitud.Text = "Lalitud";
            // 
            // FormInfoMusico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.textBoxLongitud);
            this.Controls.Add(this.textBoxLatitud);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.labelEstilos);
            this.Controls.Add(this.listBoxEstilos);
            this.Controls.Add(this.customComboBoxMunicipio);
            this.Controls.Add(this.textBoxConfirmar);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelConf);
            this.Controls.Add(this.labelMunicipio);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.pboxAtras);
            this.Controls.Add(this.botonRedondoGuardar);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInfoMusico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoMusico";
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxAtras;
        private Controles.CustomBoton botonRedondoGuardar;
        private Controles.TextBox textBoxContra;
        private Controles.TextBox textBoxCorreo;
        private Controles.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private Controles.TextBox textBoxConfirmar;
        private Controles.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelConf;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.Label labelTel;
        private Controles.CustomComboBox customComboBoxMunicipio;
        private System.Windows.Forms.ListBox listBoxEstilos;
        private System.Windows.Forms.Label labelEstilos;
        private Controles.TextBox textBoxLongitud;
        private Controles.TextBox textBoxLatitud;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.Label labelLatitud;
    }
}