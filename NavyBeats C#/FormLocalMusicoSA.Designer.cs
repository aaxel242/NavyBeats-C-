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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAzul = new System.Windows.Forms.Panel();
            this.customBotonModificar = new NavyBeats_C_.Controles.CustomBoton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonRedondoEliminar = new NavyBeats_C_.Controles.CustomBoton();
            this.botonRedondoCrear = new NavyBeats_C_.Controles.CustomBoton();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.customPanel = new NavyBeats_C_.Controles.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMusicos = new System.Windows.Forms.BindingSource(this.components);
            this.panelAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.customPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMusicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAzul
            // 
            this.panelAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelAzul.Controls.Add(this.customBotonModificar);
            this.panelAzul.Controls.Add(this.pictureBox1);
            this.panelAzul.Controls.Add(this.botonRedondoEliminar);
            this.panelAzul.Controls.Add(this.botonRedondoCrear);
            this.panelAzul.Location = new System.Drawing.Point(30, 30);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(306, 650);
            this.panelAzul.TabIndex = 10;
            // 
            // customBotonModificar
            // 
            this.customBotonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.customBotonModificar.BorderRadius = 20;
            this.customBotonModificar.FlatAppearance.BorderSize = 0;
            this.customBotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBotonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBotonModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customBotonModificar.Location = new System.Drawing.Point(81, 325);
            this.customBotonModificar.Name = "customBotonModificar";
            this.customBotonModificar.Size = new System.Drawing.Size(150, 40);
            this.customBotonModificar.TabIndex = 10;
            this.customBotonModificar.Text = "Modificar";
            this.customBotonModificar.UseVisualStyleBackColor = false;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botonRedondoEliminar
            // 
            this.botonRedondoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoEliminar.BorderRadius = 20;
            this.botonRedondoEliminar.FlatAppearance.BorderSize = 0;
            this.botonRedondoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoEliminar.Location = new System.Drawing.Point(81, 406);
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
            this.botonRedondoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoCrear.Location = new System.Drawing.Point(81, 242);
            this.botonRedondoCrear.Name = "botonRedondoCrear";
            this.botonRedondoCrear.Size = new System.Drawing.Size(150, 40);
            this.botonRedondoCrear.TabIndex = 8;
            this.botonRedondoCrear.Text = "Crear";
            this.botonRedondoCrear.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBoxNombre);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Location = new System.Drawing.Point(335, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(920, 650);
            this.panel.TabIndex = 9;
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(835, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // customPanel
            // 
            this.customPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customPanel.BorderRadius = 20;
            this.customPanel.Controls.Add(this.dataGridView);
            this.customPanel.Location = new System.Drawing.Point(373, 182);
            this.customPanel.Name = "customPanel";
            this.customPanel.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel.Size = new System.Drawing.Size(857, 440);
            this.customPanel.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.municipalityDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSourceMusicos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.dataGridView.Location = new System.Drawing.Point(10, 10);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(837, 420);
            this.dataGridView.TabIndex = 0;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "Id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Tel.";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // municipalityDataGridViewTextBoxColumn
            // 
            this.municipalityDataGridViewTextBoxColumn.DataPropertyName = "Municipality";
            this.municipalityDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipalityDataGridViewTextBoxColumn.Name = "municipalityDataGridViewTextBoxColumn";
            this.municipalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceMusicos
            // 
            this.bindingSourceMusicos.DataSource = typeof(NavyBeats_C_.Models.Users);
            // 
            // FormLocalMusicoSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.customPanel);
            this.Controls.Add(this.panelAzul);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLocalMusicoSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLocalMusico";
            this.Load += new System.EventHandler(this.FormLocalMusicoSA_Load);
            this.panelAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.customPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMusicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles.CustomBoton botonRedondoEliminar;
        private Controles.CustomBoton botonRedondoCrear;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Controles.CustomPanel customPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private Controles.CustomBoton customBotonModificar;
        private System.Windows.Forms.BindingSource bindingSourceMusicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipalityDataGridViewTextBoxColumn;
    }
}