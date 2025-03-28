﻿namespace NavyBeats_C_
{
    partial class FormUsuarios
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
            this.panel = new System.Windows.Forms.Panel();
            this.customBotonModificar = new NavyBeats_C_.Controles.CustomBoton();
            this.customPanel = new NavyBeats_C_.Controles.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.useridadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.botonRedondoEliminar = new NavyBeats_C_.Controles.CustomBoton();
            this.botonRedondoCrear = new NavyBeats_C_.Controles.CustomBoton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelAzul = new System.Windows.Forms.Panel();
            this.checkedListBoxUsuarios = new System.Windows.Forms.CheckedListBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.customPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.customBotonModificar);
            this.panel.Controls.Add(this.customPanel);
            this.panel.Controls.Add(this.pictureBoxNombre);
            this.panel.Controls.Add(this.botonRedondoEliminar);
            this.panel.Controls.Add(this.botonRedondoCrear);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Location = new System.Drawing.Point(335, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(920, 650);
            this.panel.TabIndex = 2;
            // 
            // customBotonModificar
            // 
            this.customBotonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.customBotonModificar.BorderRadius = 20;
            this.customBotonModificar.FlatAppearance.BorderSize = 0;
            this.customBotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBotonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBotonModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.customBotonModificar.Location = new System.Drawing.Point(245, 571);
            this.customBotonModificar.Name = "customBotonModificar";
            this.customBotonModificar.Size = new System.Drawing.Size(150, 40);
            this.customBotonModificar.TabIndex = 13;
            this.customBotonModificar.Text = "Modificar";
            this.customBotonModificar.UseVisualStyleBackColor = false;
            this.customBotonModificar.Click += new System.EventHandler(this.customBotonModificar_Click);
            // 
            // customPanel
            // 
            this.customPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.customPanel.BorderRadius = 20;
            this.customPanel.Controls.Add(this.dataGridView);
            this.customPanel.Location = new System.Drawing.Point(52, 152);
            this.customPanel.Name = "customPanel";
            this.customPanel.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel.Size = new System.Drawing.Size(819, 395);
            this.customPanel.TabIndex = 12;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridadminDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSourceUsuarios;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(799, 375);
            this.dataGridView.TabIndex = 0;
            // 
            // useridadminDataGridViewTextBoxColumn
            // 
            this.useridadminDataGridViewTextBoxColumn.DataPropertyName = "user_id_admin";
            this.useridadminDataGridViewTextBoxColumn.HeaderText = "Id";
            this.useridadminDataGridViewTextBoxColumn.Name = "useridadminDataGridViewTextBoxColumn";
            this.useridadminDataGridViewTextBoxColumn.ReadOnly = true;
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
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceUsuarios
            // 
            this.bindingSourceUsuarios.DataSource = typeof(NavyBeats_C_.Models.Super_User);
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
            this.botonRedondoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoEliminar.Location = new System.Drawing.Point(439, 571);
            this.botonRedondoEliminar.Name = "botonRedondoEliminar";
            this.botonRedondoEliminar.Size = new System.Drawing.Size(150, 40);
            this.botonRedondoEliminar.TabIndex = 9;
            this.botonRedondoEliminar.Text = "Eliminar";
            this.botonRedondoEliminar.UseVisualStyleBackColor = false;
            this.botonRedondoEliminar.Click += new System.EventHandler(this.botonRedondoEliminar_Click);
            // 
            // botonRedondoCrear
            // 
            this.botonRedondoCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.botonRedondoCrear.BorderRadius = 20;
            this.botonRedondoCrear.FlatAppearance.BorderSize = 0;
            this.botonRedondoCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondoCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.botonRedondoCrear.Location = new System.Drawing.Point(52, 571);
            this.botonRedondoCrear.Name = "botonRedondoCrear";
            this.botonRedondoCrear.Size = new System.Drawing.Size(150, 40);
            this.botonRedondoCrear.TabIndex = 8;
            this.botonRedondoCrear.Text = "Crear";
            this.botonRedondoCrear.UseVisualStyleBackColor = false;
            this.botonRedondoCrear.Click += new System.EventHandler(this.botonRedondoCrear_Click);
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
            // panelAzul
            // 
            this.panelAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelAzul.Controls.Add(this.checkedListBoxUsuarios);
            this.panelAzul.Controls.Add(this.pbSalir);
            this.panelAzul.Location = new System.Drawing.Point(30, 29);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(306, 650);
            this.panelAzul.TabIndex = 8;
            // 
            // checkedListBoxUsuarios
            // 
            this.checkedListBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.checkedListBoxUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxUsuarios.CheckOnClick = true;
            this.checkedListBoxUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.checkedListBoxUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.checkedListBoxUsuarios.FormattingEnabled = true;
            this.checkedListBoxUsuarios.Items.AddRange(new object[] {
            "Super",
            "Admin",
            "Mantenimiento"});
            this.checkedListBoxUsuarios.Location = new System.Drawing.Point(18, 277);
            this.checkedListBoxUsuarios.Name = "checkedListBoxUsuarios";
            this.checkedListBoxUsuarios.Size = new System.Drawing.Size(278, 99);
            this.checkedListBoxUsuarios.TabIndex = 14;
            this.checkedListBoxUsuarios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxUsuarios_ItemCheck);
            // 
            // pbSalir
            // 
            this.pbSalir.Image = global::NavyBeats_C_.Properties.Resources.imgSalirDorado;
            this.pbSalir.Location = new System.Drawing.Point(18, 17);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(61, 59);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 8;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelAzul);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.panel.ResumeLayout(false);
            this.customPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.PictureBox pbSalir;
        private Controles.CustomBoton botonRedondoEliminar;
        private Controles.CustomBoton botonRedondoCrear;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private Controles.CustomPanel customPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSourceUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsuarios;
        private Controles.CustomBoton customBotonModificar;
    }
}