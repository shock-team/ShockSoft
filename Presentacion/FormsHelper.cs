using System;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public static class FormsHelper
    {
        public static string TextToCurrency(string pText)
        {
            return String.Format("{0:C2}", float.Parse(pText));
        }
        public static string TextToCurrency(float pFloat)
        {
            return String.Format("{0:C2}", pFloat);
        }

        public static string CurrencyToText(string pCurrency)
        {
            return pCurrency.Substring(2);
        }

        public static string BoolToText(bool pBoolean)
        {
            if (pBoolean)
            {
                return "Sí";
            }
            else
            {
                return "No";
            }
        }

        public static string NameFormatter(string pNombre, string pApellido)
        {
            return String.Format("{0}, {1}", pApellido, pNombre);
        }

        public static void SiguientePagina(Button btnSiguiente, Button btnAnterior, Label lblPagActual, int cantElem)
        {
            if (lblPagActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = true;
                btnAnterior.Visible = true;
            }
            lblPagActual.Text = (int.Parse(lblPagActual.Text) + 1).ToString();
            if (int.Parse(lblPagActual.Text) >= (cantElem / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
        }

        public static void PaginaAnterior(Button btnSiguiente, Button btnAnterior, Label lblPagActual)
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            lblPagActual.Text = (int.Parse(lblPagActual.Text) - 1).ToString();
            if (lblPagActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = false;
                btnAnterior.Visible = false;
            }
        }
    }
}
