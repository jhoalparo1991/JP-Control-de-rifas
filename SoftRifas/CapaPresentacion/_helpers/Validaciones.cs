using System.Windows.Forms;

namespace CapaPresentacion._helpers
{
    public class Validaciones
    {
        public static void numeroDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void completarCampos(TextBox textBox, string value = "0")
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = value;
            }
        }
    }
}
