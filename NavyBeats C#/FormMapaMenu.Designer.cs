namespace NavyBeats_C_
{
    partial class FormMapaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapaMenu));
            this.panelMapa = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panelMenuMapa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalMapa = new System.Windows.Forms.Button();
            this.btnMusicoMapa = new System.Windows.Forms.Button();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panelMapa.TabIndex = 3;
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
            this.gMapControl1.Zoom = 0D;
            // 
            // panelMenuMapa
            // 
            this.panelMenuMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelMenuMapa.Controls.Add(this.label2);
            this.panelMenuMapa.Controls.Add(this.label1);
            this.panelMenuMapa.Controls.Add(this.btnLocalMapa);
            this.panelMenuMapa.Controls.Add(this.btnMusicoMapa);
            this.panelMenuMapa.Controls.Add(this.pboxAtras);
            this.panelMenuMapa.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMapa.Name = "panelMenuMapa";
            this.panelMenuMapa.Size = new System.Drawing.Size(291, 650);
            this.panelMenuMapa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disponibilidad Musico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(46, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visualizar Locales";
            // 
            // btnLocalMapa
            // 
            this.btnLocalMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.btnLocalMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalMapa.FlatAppearance.BorderSize = 0;
            this.btnLocalMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalMapa.Location = new System.Drawing.Point(44, 415);
            this.btnLocalMapa.Name = "btnLocalMapa";
            this.btnLocalMapa.Size = new System.Drawing.Size(200, 200);
            this.btnLocalMapa.TabIndex = 3;
            this.btnLocalMapa.UseVisualStyleBackColor = false;
            this.btnLocalMapa.Click += new System.EventHandler(this.btnLocalMapa_Click);
            // 
            // btnMusicoMapa
            // 
            this.btnMusicoMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.btnMusicoMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusicoMapa.FlatAppearance.BorderSize = 0;
            this.btnMusicoMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusicoMapa.Location = new System.Drawing.Point(44, 153);
            this.btnMusicoMapa.Name = "btnMusicoMapa";
            this.btnMusicoMapa.Size = new System.Drawing.Size(200, 200);
            this.btnMusicoMapa.TabIndex = 2;
            this.btnMusicoMapa.UseVisualStyleBackColor = false;
            this.btnMusicoMapa.Click += new System.EventHandler(this.btnMusicoMapa_Click);
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
            // FormMapaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelMapa);
            this.Name = "FormMapaMenu";
            this.Text = "FormMapaMenu";
            this.Load += new System.EventHandler(this.FormMapaMenu_Load);
            this.panelMapa.ResumeLayout(false);
            this.panelMenuMapa.ResumeLayout(false);
            this.panelMenuMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuMapa;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnLocalMapa;
        private System.Windows.Forms.Button btnMusicoMapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}