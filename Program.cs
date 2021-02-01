﻿using System;
using System.Globalization;
using System.Windows.Forms;
using ShockSoft.Presentacion;


namespace ShockSoft
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var culture = new CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MenuPrincipal());
        }
    }
}
