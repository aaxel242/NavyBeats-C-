namespace NavyBeats_C_
{
    partial class FormLocalMusico
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
            this.panelCalendarioFondo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxAtras = new System.Windows.Forms.PictureBox();
            this.panelCalendarioFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCalendarioFondo
            // 
            this.panelCalendarioFondo.AutoSize = true;
            this.panelCalendarioFondo.BackColor = System.Drawing.Color.White;
            this.panelCalendarioFondo.Controls.Add(this.pictureBox1);
            this.panelCalendarioFondo.Controls.Add(this.pboxAtras);
            this.panelCalendarioFondo.Location = new System.Drawing.Point(35, 30);
            this.panelCalendarioFondo.Name = "panelCalendarioFondo";
            this.panelCalendarioFondo.Size = new System.Drawing.Size(1215, 650);
            this.panelCalendarioFondo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NavyBeats_C_.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1142, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pboxAtras
            // 
            this.pboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pboxAtras.Image = global::NavyBeats_C_.Properties.Resources.imgAtras;
            this.pboxAtras.Location = new System.Drawing.Point(12, 13);
            this.pboxAtras.Name = "pboxAtras";
            this.pboxAtras.Size = new System.Drawing.Size(61, 59);
            this.pboxAtras.TabIndex = 2;
            this.pboxAtras.TabStop = false;
            // 
            // FormLocalMusico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NavyBeats_C_.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panelCalendarioFondo);
            this.Name = "FormLocalMusico";
            this.Text = "FormLocalMusico";
            this.panelCalendarioFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCalendarioFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxAtras;
    }
}