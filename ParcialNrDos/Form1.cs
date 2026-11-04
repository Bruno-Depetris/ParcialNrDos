using System;
using System.Collections;
using System.Windows.Forms;

namespace ParcialNrDos {
    public partial class Form1 : Form {
        Datos datos = new Datos();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CargarBarrios();
            CargarPropiedades();
        }

        private void CargarBarrios() {
            Hashtable barrios = datos.ObtenerBarrios();

            cmbBarrio.Items.Clear();
            cmbBarrio.Items.Insert(0, "Seleccionar un barrio");
            
            foreach (var barrio in barrios) {
                cmbBarrio.Items.Add(barrio.Key + " - " + barrio.Value);
            }

            cmbBarrio.SelectedIndex = 0;
        }

        private void CargarPropiedades() {
            ArrayList aLista = datos.ObtenerPropiedades();
            dgvPropiedades.DataSource = aLista;
        }
        private void grpPropiedad_Enter(object sender, EventArgs e) {

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (nombre == "") {
                MessageBox.Show("Debe ingresar el nombre");
                return;
            }

            if (direccion == "") {
                MessageBox.Show("Debe ingresar la direccion");
                return;
            }

            if (cmbBarrio.SelectedIndex == 0) {
                MessageBox.Show("Debe seleccionar un barrio ");
                return;
            }

            decimal precio;
            if (decimal.TryParse(txtPrecio.Text.Trim(), out precio) == false) {
                MessageBox.Show("El precio debe ser un nmro decimal");
                return;
            }

            if (precio <= 0) {
                MessageBox.Show("El precio debe ser mayor que cero");
                return;
            }

            string textoBarrio = cmbBarrio.SelectedItem.ToString();
            int idBarrio = int.Parse(textoBarrio.Split('-')[0].Trim());

            Propiedad propiedad = new Propiedad();

            propiedad.Nombre = nombre;
            propiedad.Direccion = direccion;
            propiedad.Precio = precio;
            propiedad.IdBarrio = idBarrio;


            datos.GuardarPropiedad(propiedad);
            MessageBox.Show("Propiedad guardada ");
            LimpiarCampos();
            CargarPropiedades();

        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            int idPropiedad;
            if (int.TryParse(txtIdEliminar.Text.Trim(), out idPropiedad) == false) {
                MessageBox.Show("El Id debe ser un numero entero");
                return;
            }

            bool eliminada = datos.EliminarPropiedad(idPropiedad);

            if (eliminada) {
                MessageBox.Show("Propiedad eliminada correctamente");
                txtIdEliminar.Text = "";
                CargarPropiedades();
            } else {
                MessageBox.Show("No existe una propiedad con el Id " + idPropiedad, "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void LimpiarCampos() {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtPrecio.Text = "";
            cmbBarrio.SelectedIndex = 0;
        }

        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
