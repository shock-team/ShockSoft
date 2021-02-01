using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ZonaSoft.Presentacion
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
        
        public static string TextToCurrency(double pDouble)
        {
            return String.Format("{0:C2}", pDouble);
        }

        public static string CurrencyToText(string pCurrency)
        {
            string aux = pCurrency.Replace(" ", "");
            string text = aux.Replace("$", "");
            return text;
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

        public static void DobleClickCeldaLinea(DataGridView pTablaDeLineas, Form pOwner)
        {
            int productoSeleccionado = int.Parse((string)(pTablaDeLineas.CurrentRow.Cells[0].Value));
            int cantidad = (int)(pTablaDeLineas.CurrentRow.Cells[3].Value);

            List<int> listaDeIDs = new List<int>();
            foreach (DataGridViewRow fila in pTablaDeLineas.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    listaDeIDs.Add(int.Parse(fila.Cells[0].Value.ToString()));
                }
            }

            Form_AgregarLineaDeVenta form_AgregarLinea = new Form_AgregarLineaDeVenta();

            form_AgregarLinea.Owner = pOwner;
            form_AgregarLinea.listaDeIDs = listaDeIDs;
            form_AgregarLinea.AgregarProducto(productoSeleccionado, cantidad);

            pOwner.Hide();
            form_AgregarLinea.CambiarColor();
            form_AgregarLinea.ShowDialog();
            pOwner.Show();
        }
    }
}
