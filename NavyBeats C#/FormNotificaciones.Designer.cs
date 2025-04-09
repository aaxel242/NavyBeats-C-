namespace NavyBeats_C_
{
    partial class FormNotificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotificaciones));
            this.panelNotificaciones = new System.Windows.Forms.Panel();
            this.panelNotificaciones2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNotificaciones.SuspendLayout();
            this.panelNotificaciones2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNotificaciones
            // 
            this.panelNotificaciones.BackColor = System.Drawing.Color.White;
            this.panelNotificaciones.Controls.Add(this.panelNotificaciones2);
            this.panelNotificaciones.Controls.Add(this.pboxAtras);
            this.panelNotificaciones.Controls.Add(this.pictureBox1);
            this.panelNotificaciones.Location = new System.Drawing.Point(30, 30);
            this.panelNotificaciones.Name = "panelNotificaciones";
            this.panelNotificaciones.Size = new System.Drawing.Size(1225, 650);
            this.panelNotificaciones.TabIndex = 2;
            // 
            // panelNotificaciones2
            // 
            this.panelNotificaciones2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panelNotificaciones2.Controls.Add(this.flowLayoutPanelTickets);
            this.panelNotificaciones2.Controls.Add(this.lblNotificaciones);
            this.panelNotificaciones2.Location = new System.Drawing.Point(141, 39);
            this.panelNotificaciones2.Name = "panelNotificaciones2";
            this.panelNotificaciones2.Size = new System.Drawing.Size(960, 573);
            this.panelNotificaciones2.TabIndex = 5;
            // 
            // flowLayoutPanelTickets
            // 
            this.flowLayoutPanelTickets.AutoScroll = true;
            this.flowLayoutPanelTickets.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTickets.Location = new System.Drawing.Point(20, 93);
            this.flowLayoutPanelTickets.Name = "flowLayoutPanelTickets";
            this.flowLayoutPanelTickets.Size = new System.Drawing.Size(919, 457);
            this.flowLayoutPanelTickets.TabIndex = 7;
            this.flowLayoutPanelTickets.WrapContents = false;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.lblNotificaciones.Location = new System.Drawing.Point(385, 22);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(199, 31);
            this.lblNotificaciones.TabIndex = 6;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = ((System.Drawing.Image)(resources.GetObject("pboxAtras.Image")));
            this.pboxAtras.Location = new System.Drawing.Point(22, 13);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
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
            // FormNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelNotificaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNotificaciones";
            this.Text = "FormNotificaciones";
            this.Load += new System.EventHandler(this.FormNotificaciones_Load);
            this.panelNotificaciones.ResumeLayout(false);
            this.panelNotificaciones2.ResumeLayout(false);
            this.panelNotificaciones2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNotificaciones;
        private System.Windows.Forms.PictureBox pboxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelNotificaciones2;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTickets;
    }
}