namespace NavyBeats_C_
{
    partial class FormMapaArtistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapaArtistas));
            this.panelMapa = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panelMenuMapa = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMusicos = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxMusicos = new System.Windows.Forms.ComboBox();
            this.labelNombre = new System.Windows.Forms.Label();
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
            this.gMapControl1.Zoom = 0D;
            // 
            // panelMenuMapa
            // 
            this.panelMenuMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.panelMenuMapa.Controls.Add(this.flowLayoutPanelMusicos);
            this.panelMenuMapa.Controls.Add(this.cboxMusicos);
            this.panelMenuMapa.Controls.Add(this.labelNombre);
            this.panelMenuMapa.Controls.Add(this.pboxAtras);
            this.panelMenuMapa.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMapa.Name = "panelMenuMapa";
            this.panelMenuMapa.Size = new System.Drawing.Size(291, 650);
            this.panelMenuMapa.TabIndex = 2;
            // 
            // flowLayoutPanelMusicos
            // 
            this.flowLayoutPanelMusicos.AutoScroll = true;
            this.flowLayoutPanelMusicos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMusicos.Location = new System.Drawing.Point(23, 199);
            this.flowLayoutPanelMusicos.Name = "flowLayoutPanelMusicos";
            this.flowLayoutPanelMusicos.Size = new System.Drawing.Size(252, 403);
            this.flowLayoutPanelMusicos.TabIndex = 10;
            this.flowLayoutPanelMusicos.WrapContents = false;
            // 
            // cboxMusicos
            // 
            this.cboxMusicos.FormattingEnabled = true;
            this.cboxMusicos.Location = new System.Drawing.Point(25, 155);
            this.cboxMusicos.Name = "cboxMusicos";
            this.cboxMusicos.Size = new System.Drawing.Size(252, 21);
            this.cboxMusicos.TabIndex = 9;
            this.cboxMusicos.SelectedIndexChanged += new System.EventHandler(this.cboxMusicos_SelectedIndexChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(177)))), ((int)(((byte)(129)))));
            this.labelNombre.Location = new System.Drawing.Point(20, 114);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(201, 30);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre del musico";
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
            // FormMapaArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelMapa);
            this.Name = "FormMapaArtistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMapaArtistas";
            this.Load += new System.EventHandler(this.FormMapaArtistas_Load);
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
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cboxMusicos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMusicos;
    }
}