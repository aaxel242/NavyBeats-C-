using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NavyBeats_C_.Models;

namespace NavyBeats_C_
{
    public partial class FormCalendario : Form
    {
        // Variables para almacenar el año y mes actuales
        private int currentYear;
        private int currentMonth;
        // Lista para almacenar los eventos del día seleccionado
        private List<Models.EventoInfo> eventosDelDia = new List<Models.EventoInfo>();
        // Variables para almacenar el índice del evento actual
        private int eventoActualIndex = 0;


        public FormCalendario()
        {
            InitializeComponent();

            lblLunes.Text = Resources.Strings.lblLunes;
            lblMartes.Text = Resources.Strings.lblMartes;
            lblMiercoles.Text = Resources.Strings.lblMiercoles;
            lblJueves.Text = Resources.Strings.lblJueves;
            lblViernes.Text = Resources.Strings.lblViernes;
            lblSabado.Text = Resources.Strings.lblSabado;
            lblDomingo.Text = Resources.Strings.lblDomingo;

            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
            MostrarDias(currentYear, currentMonth);
        }

        /// <summary>
        /// Método que se ejecuta al cargar el formulario. Ajusta el color de fondo del panel y establece las imágenes de los botones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalendario_Load(object sender, EventArgs e)
        {
            panelCalendarioFondo.BackColor = Color.FromArgb(216, 255, 255, 255);

            btnRetroceder.BackgroundImage = Properties.Resources.imgFlechaRetroceder;
            btnRetroceder.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvanzar.BackgroundImage = Properties.Resources.imgFlechaAvanzar;
            btnAvanzar.BackgroundImageLayout = ImageLayout.Stretch;

            //Models.CalendarioOrm.InsertOffers();
            MostrarDias(currentYear, currentMonth);
        }

        /// <summary>
        /// Método que muestra los días del mes y año especificados en el panel de días.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        private void MostrarDias(int year, int month)
        {
            panelDias.Controls.Clear();
            panelDias.ColumnStyles.Clear();
            panelDias.RowStyles.Clear();
            panelDias.ColumnCount = 7;
            panelDias.RowCount = 6;

            // Hacemos que cada columna y fila ocupe el mismo espacio proporcionalmente.
            for (int i = 0; i < 7; i++)
                panelDias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
            for (int i = 0; i < 6; i++)
                panelDias.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));

            // Fecha del primer día del mes.
            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Día de la semana en que inicia el mes.
            int startDayOfWeek = (int)startOfMonth.DayOfWeek;
            startDayOfWeek = (startDayOfWeek + 6) % 7; // Ajuste para que lunes sea la posición 0.

            bool esMesActual = (year == DateTime.Now.Year && month == DateTime.Now.Month);
            int diaActual = DateTime.Now.Day;

            // Crear los botones de los días.
            for (int day = 1; day <= daysInMonth; day++)
            {
                int index = day + startDayOfWeek - 1;
                int row = index / 7;
                int col = index % 7;

                Button btnDay = new Button();
                btnDay.Dock = DockStyle.Fill;
                btnDay.Text = day.ToString();
                btnDay.Tag = new DateTime(year, month, day);
                btnDay.Click += BtnDia_Click;

                // Cambiar el color de fondo del botón si es el día actual.
                if (esMesActual && day == diaActual)
                {
                    btnDay.BackColor = Color.LightBlue;
                }

                panelDias.Controls.Add(btnDay, col, row);
            }

            // Llama al método que resalta los días con eventos
            ResaltarDiasConEventos();

            lblMes.Text = $"{ObtenerNombreMes(month)} {year}";
        }

        /// <summary>
        /// Resalta los días que tienen eventos en el calendario.
        /// </summary>
        private void ResaltarDiasConEventos()
        {
            // Se consultan las ofertas activas de ambas tablas según los criterios definidos
            using (var context = new dam04Entities())
            {
                // Obtener las fechas de los eventos de Offer_dir.
                var offerDirDates = context.Offer_dir
                    .Where(o => o.agreement == 1 && o.done == 0 && o.event_date != null)
                    .Select(o => o.event_date)
                    .AsEnumerable() // Cambia a LINQ to Objects para usar DateTime.Parse
                    .Select(ed => DateTime.TryParse(ed, out var dt) ? dt : DateTime.MinValue)
                    .Where(dt => dt != DateTime.MinValue)
                    .ToList();

                // Obtener las fechas de los eventos de Offer_In.
                var offerInDates = context.Offer_In
                      .Where(o => o.music_id_final != null && o.event_date != null)
                      .Select(o => o.event_date)
                      .AsEnumerable()
                      .Select(ed => DateTime.TryParse(ed, out var dt) ? dt : DateTime.MinValue)
                      .Where(dt => dt != DateTime.MinValue)
                      .ToList();

                // Combina ambas listas y elimina duplicados.
                var eventDates = offerDirDates.Union(offerInDates).ToList();

                // Recorre los botones en panelDias y resaltar aquellos cuyo Tag (fecha) coincide con algún evento.
                foreach (Control ctrl in panelDias.Controls)
                {
                    if (ctrl is Button btn && btn.Tag is DateTime btnDate)
                    {
                        // Compara solo la parte de la fecha
                        if (eventDates.Any(ev => ev.Date == btnDate.Date))
                        {
                            btn.BackColor = Color.FromArgb(229, 177, 129);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Muestra los eventos del día seleccionado al hacer clic en un botón de día.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDia_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is DateTime fecha)
            {
                eventosDelDia = Models.CalendarioOrm.ObtenerEventosConPosicion(fecha);
                eventoActualIndex = 0;
                MostrarEventoActual();
            }
        }
        /// <summary>
        /// Muestra los eventos actuales en la interfaz de usuario.
        /// </summary>
        private void MostrarEventoActual()
        {            
            if (eventosDelDia != null && eventosDelDia.Count > 0)
            {
                btnAvanzar.Visible = true;
                btnRetroceder.Visible = true;
                lblNumEventos.Visible = true;
                lblMusico.Visible = true;
                lblMusico.Text = Resources.Strings.lblMusico;
                lblLocal.Visible = true;
                lblHorario.Visible = true;
                lblPrecio.Visible = true;

                var evt = eventosDelDia[eventoActualIndex];

                lblMusicoSelect.Text = evt.Musico;
                lblLocalSelect.Text = evt.Local;

                // Convertir evt.Horario (string) a DateTime y luego formatear a "HH:mm"
                if (DateTime.TryParse(evt.Horario, out DateTime dtHorario))
                {
                    lblHorarioSelect.Text = dtHorario.ToString("HH:mm");
                }
                else
                {
                    lblHorarioSelect.Text = evt.Horario;
                }

                lblPrecioSelect.Text = evt.Salario.ToString("C");

                lblNumEventos.Text = $"{eventoActualIndex + 1}/{eventosDelDia.Count}";
            }
            else
            {
                btnAvanzar.Visible = false;
                btnRetroceder.Visible = false;
                lblNumEventos.Visible = false;
                lblMusico.Visible = true;
                lblMusico.Text = Resources.Strings.lblSinEvento;
                lblLocal.Visible = false;
                lblHorario.Visible = false;
                lblPrecio.Visible = false;
                lblMusicoSelect.Text = "";
                lblLocalSelect.Text = "";
                lblHorarioSelect.Text = "";
                lblPrecioSelect.Text = "";
            }
        }


        /// <summary>
        /// Método que obtiene el nombre del mes en español según el número del mes.
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        private string ObtenerNombreMes(int mes)
        {
            string[] meses = { Resources.Strings.lblEnero, Resources.Strings.lblFebrero, Resources.Strings.lblMarzo, Resources.Strings.lblAbril,
                Resources.Strings.lblMayo, Resources.Strings.lblJunio, Resources.Strings.lblJulio, Resources.Strings.lblAgosto,
                Resources.Strings.lblSeptiembre, Resources.Strings.lblOctubre, Resources.Strings.lblNoviembre, Resources.Strings.lblDiciembre };
            return meses[mes - 1];
        }
        /// <summary>
        /// Aumenta el mes actual y muestra los días correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Disminuye el mes actual y muestra los días correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Aumenta el índice del evento actual y muestra el siguiente evento de el dia seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvanzar_Click_1(object sender, EventArgs e)
        {
            if (eventosDelDia != null && eventosDelDia.Count > 0)
            {
                eventoActualIndex = (eventoActualIndex + 1) % eventosDelDia.Count;
                MostrarEventoActual();
            }
        }
        /// <summary>
        /// Disminuye el índice del evento actual y muestra el evento anterior de el dia seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetroceder_Click_1(object sender, EventArgs e)
        {
            if (eventosDelDia != null && eventosDelDia.Count > 0)
            {
                eventoActualIndex = (eventoActualIndex - 1 + eventosDelDia.Count) % eventosDelDia.Count;
                MostrarEventoActual();
            }
        }
        /// <summary>
        /// Cierra el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}