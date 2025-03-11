using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavyBeats_C_.BaseDatos;

namespace NavyBeats_C_
{
    public partial class FormCalendario : Form
    {
        private int currentYear;
        private int currentMonth;

        public FormCalendario()
        {
            InitializeComponent();

            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
            MostrarDias(currentYear, currentMonth);
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            // Centrar el formulario
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }



        private void MostrarDias(int year, int month)
        {
            panelDias.Controls.Clear();
            panelDias.ColumnStyles.Clear();
            panelDias.RowStyles.Clear();
            panelDias.ColumnCount = 7; 
            panelDias.RowCount = 6;    

            // Hacemos que cada columna y fila ocupe el mismo espacio proporcionalmente
            for (int i = 0; i < 7; i++)
                panelDias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int i = 0; i < 6; i++)
                panelDias.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));

            // Fecha del primer día del mes
            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Día de la semana en que inicia el mes (Sunday=0, Monday=1, etc.)
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;
            startDayOfWeek = (startDayOfWeek + 6) % 7; // Ajuste para que lunes sea 0

            bool esMesActual = (year == DateTime.Now.Year && month == DateTime.Now.Month);
            int diaActual = DateTime.Now.Day;

            // Crear los botones de los días
            for (int day = 1; day <= daysInMonth; day++)
            {
                int index = day + startDayOfWeek - 1;
                int row = index / 7;
                int col = index % 7;

                Button btnDay = new Button();
                btnDay.Dock = DockStyle.Fill; // El botón ocupa todo el espacio de la celda
                btnDay.Text = day.ToString();
                btnDay.Tag = new DateTime(year, month, day);
                btnDay.Click += BtnDia_Click;

                if (esMesActual && day == diaActual)
                {
                    btnDay.BackColor = Color.LightBlue; 
                }

                panelDias.Controls.Add(btnDay, col, row);
            }

            lblMes.Text = $"{ObtenerNombreMes(month)} {year}";
        }


        private void BtnDia_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is DateTime)
            {
                DateTime fecha = (DateTime)btn.Tag;
                // Enviar luego a otro formulario.
               
                MessageBox.Show("Día seleccionado: " + fecha.ToShortDateString());
            }
        }

        private string ObtenerNombreMes(int mes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                           "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[mes - 1];
        }

        private void pBoxFlechaDerecha_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            MostrarDias(currentYear, currentMonth);
        }

        private void pBoxFlechaIzquierda_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            MostrarDias(currentYear, currentMonth);
        }

        private void lblMes_Click(object sender, EventArgs e)
        {
            // Posicionar el DateTimePicker justo debajo del label
            dateTimePickerCalendario.Location = new Point(lblMes.Left, lblMes.Bottom);
            // Asigna el valor actual del calendario
            dateTimePickerCalendario.Value = new DateTime(currentYear, currentMonth, 1);
            // Mostrar el control y darle foco
            dateTimePickerCalendario.Visible = true;
            dateTimePickerCalendario.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza el año y mes a partir del valor seleccionado
            currentYear = dateTimePickerCalendario.Value.Year;
            currentMonth = dateTimePickerCalendario.Value.Month;
            // Actualiza el calendario
            MostrarDias(currentYear, currentMonth);
            // Oculta el DateTimePicker
            dateTimePickerCalendario.Visible = false;
        }


    }
}