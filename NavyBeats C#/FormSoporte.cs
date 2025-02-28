using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetroFramework.Drawing.MetroPaint;

namespace NavyBeats_C_
{
    public partial class FormSoporte : Form
    {
        private CustomCheckBox myCheckBox; // Checkbox declarado a nivel de clase

        public FormSoporte()
        {
            InitializeComponent();
        }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            AplicarEsquinasRedondeadas(panelFormulario, 30);
            ConfigurarCheckBox(); // Se llama al método para configurar el checkbox

            // Aplicar fuente personalizada
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("Resources\\Fonts\\Montserrat-Regular.ttf");

            lblFornSoporteTit.Font = new Font(fonts.Families[0], 20, FontStyle.Bold);
            lblTipo.Font = new Font(fonts.Families[0], 14, FontStyle.Bold);
        }

        private void ConfigurarCheckBox()
        {
            myCheckBox = new CustomCheckBox()
            {
                Text = "Aceptar términos",
                BaseCheckSize = 10,
                CheckedColor = Color.Red,
                Location = new Point(50, 50),
                AutoSize = false,
                Size = new Size(250, 40)
            };

            this.Controls.Add(myCheckBox);
        }

        private void AplicarEsquinasRedondeadas(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            // Esquina superior izquierda (redondeada)
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);

            // Línea superior
            path.AddLine(radio, 0, panel.Width - radio, 0);

            // Esquina superior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);

            // Línea derecha
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);

            // Esquina inferior derecha (redondeada)
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);

            // Línea inferior
            path.AddLine(panel.Width - radio, panel.Height, 0, panel.Height);

            // Línea izquierda
            path.AddLine(0, panel.Height, 0, radio);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void pboxAtras_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
