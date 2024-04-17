using System.Windows.Forms;

namespace CapaPresentacion._helpers
{
    public class DatosMaestros
    {

        public static void mostrarFormasDePago(ComboBox cbx)
        {
            cbx.Items.Add("Efectivo en Caja");

            cbx.Items.Add("Consignacion Bancaria");

            cbx.Items.Add("Transferencia Virtual");

            cbx.Items.Add("Nequi");

            cbx.Items.Add("Daviplata");

            cbx.Items.Add("TransfiYa");

            cbx.Items.Add("Bono");

            cbx.Items.Add("Bancolombia");

            cbx.Items.Add("Banco Caja Social");

            cbx.Items.Add("Banco Davivienda");

            cbx.Items.Add("Banco de Bogota");

            cbx.Items.Add("Banco Pichincha");

            cbx.Items.Add("BBVA");
        }


    }
}
