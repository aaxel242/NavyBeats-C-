namespace NavyBeats_C_
{
    partial class FormMapaLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapaLocales));
            this.panelMapa = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panelMenuMapa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxMunicipios = new System.Windows.Forms.ComboBox();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMapa.SuspendLayout();
            this.panelMenuMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMapa
            // 
            this.panelMapa.BackColor = System.Drawing.Color.White;
            this.panelMapa.Controls.Add(this.gMapControl1);
            this.panelMapa.Controls.Add(this.panelMenuMapa);
            this.panelMapa.Controls.Add(this.pictureBox1);
            this.panelMapa.Location = new System.Drawing.Point(30, 30);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(1225, 650);
            this.panelMapa.TabIndex = 4;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(360, 91);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(798, 511);
            this.gMapControl1.TabIndex = 3;
            this.gMapControl1.TabStop = false;
            this.gMapControl1.Zoom = 0D;
            // 
            // panelMenuMapa
            // 
            this.panelMenuMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelMenuMapa.Controls.Add(this.tableLayoutPanel1);
            this.panelMenuMapa.Controls.Add(this.button1);
            this.panelMenuMapa.Controls.Add(this.cBoxMunicipios);
            this.panelMenuMapa.Controls.Add(this.pboxAtras);
            this.panelMenuMapa.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMapa.Name = "panelMenuMapa";
            this.panelMenuMapa.Size = new System.Drawing.Size(291, 650);
            this.panelMenuMapa.TabIndex = 2;
            this.panelMenuMapa.TabStop = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.button1.BackgroundImage = global::NavyBeats_C_.Properties.Resources.imgBuscar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(250, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cBoxMunicipios
            // 
            this.cBoxMunicipios.BackColor = System.Drawing.Color.White;
            this.cBoxMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMunicipios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxMunicipios.FormattingEnabled = true;
            this.cBoxMunicipios.Location = new System.Drawing.Point(23, 153);
            this.cBoxMunicipios.Name = "cBoxMunicipios";
            this.cBoxMunicipios.Size = new System.Drawing.Size(221, 21);
            this.cBoxMunicipios.TabIndex = 4;
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = global::NavyBeats_C_.Properties.Resources.imgSalirDorado;
            this.pboxAtras.Location = new System.Drawing.Point(12, 13);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(56, 56);
            this.pboxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxAtras.TabIndex = 1;
            this.pboxAtras.TabStop = false;
            this.pboxAtras.Click += new System.EventHandler(this.pboxAtras_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 197);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 426);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormMapaLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelMapa);
            this.Name = "FormMapaLocales";
            this.Text = "FormMapaLocales";
            this.Load += new System.EventHandler(this.FormMapaLocales_Load);
            this.panelMapa.ResumeLayout(false);
            this.panelMenuMapa.ResumeLayout(false);
            this.panelMenuMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMapa;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panelMenuMapa;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cBoxMunicipios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}