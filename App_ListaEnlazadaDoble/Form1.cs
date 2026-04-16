using System.Runtime.Intrinsics.X86;

namespace App_ListaEnlazadaDoble
{
    public partial class Form1 : Form
    {
        ListaD l = new ListaD();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                if (byte.TryParse(txtEdad.Text, out byte ed) && ed <= 150)
                {
                    listView1.Items.Clear();
                    l.Insertar(txtNombre.Text.Trim(), ed);
                    l.Mostrar(listView1);
                    txtNombre.Clear();
                    txtEdad.Clear();
                }
                else MessageBox.Show("Solo se permiten edades de 0-150.");
            }
            else MessageBox.Show("No se permiten nombres vacios.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                NodoD buscar = l.Buscar(txtNombre.Text.Trim());
                if (buscar != null)
                {
                    MessageBox.Show($"Nombre: {buscar.Nombre} \nEdad: {buscar.Edad}");
                }
                else MessageBox.Show("No existe!");

            }
            else MessageBox.Show("No se permiten nombres vacios.");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string select = listView1.SelectedItems[0].Text;
                if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    if (byte.TryParse(txtEdad.Text, out byte ed) && ed <= 150)
                    {
                        listView1.Items.Clear();
                        l.Modificar(select, txtNombre.Text, ed);
                        l.Mostrar(listView1);
                        txtNombre.Clear();
                        txtEdad.Clear();
                    }
                    else MessageBox.Show("Modificar a una edad entre 0 - 150");

                } else MessageBox.Show("Modificar a un nombre válido!");
                
            } else MessageBox.Show("Seleccione un nombre a modificar!");
        }
    }
}
