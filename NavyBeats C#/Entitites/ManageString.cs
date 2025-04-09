using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavyBeats_C_.Entitites
{
    public static class ManageString
    {
        public static string idioma { get; set; } = "es";

        public static void CambiarIdioma()
        {
            CultureInfo culture = new CultureInfo(idioma);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
