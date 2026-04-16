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
                else MessageBox.Show("Solo se permiten edades de 0-150");   
            }
            else MessageBox.Show("No se permiten nombres vacio.");
        }
    }
}
