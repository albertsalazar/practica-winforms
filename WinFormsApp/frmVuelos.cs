using System.Data;
using System.Diagnostics.Contracts;

namespace WinFormsApp
{
    public partial class frmVuelos : Form
    {
        public frmVuelos()
        {
            InitializeComponent();
        }
        #region Enumerado
        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;
        #endregion

        #region Eventos

        private void frmVuelos_Load(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            CargarYConfigurarGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool IsOk = false;
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Vuelo v = ObtenerInformacion();
                IsOk = Repositorio.EliminarVuelo(v);

                // Si todo ha ido bien, mostramos un mensaje
                if (IsOk)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool isOk = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la información
                Vuelo v = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        isOk = Repositorio.CrearVuelo(v);
                        break;
                    case ModoEdicion.modificar:
                        isOk = Repositorio.ModificarVuelo(v);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (isOk)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Origen y destino son obligatorios.");
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir de la edición?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvListado.SelectedRows.Count == 1)
                {
                    // Recargamos su información en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvListado.SelectedRows[0]);
                }
            }
        }
        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListado.Rows[e.RowIndex].Selected = true;
        }
        private void dgvListado_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operación que no sea que ha cambiado la selección de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }
        #endregion
        #region Métodos

        private void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerVuelos();
            dgvListado.DataSource = ds.Tables[0];

            dgvListado.Columns["Id"].Width = 40;
            dgvListado.Columns["Origen"].Width = 150;
            dgvListado.Columns["Destino"].Width = 150;
            dgvListado.Columns["Fecha"].Width = 150;
            dgvListado.Columns["Pasajeros"].Width = 150;

            // Formato fecha en español
            dgvListado.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            SeleccionarPrimeraFilaGrid();

        }

        private void SeleccionarPrimeraFilaGrid()
        {
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.Rows[0].Selected = true;
            }
        }
        public void ModoPantallaEdicion()
        {
            // Limpiamos sólo si es modo creación, si es modo edición dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                txtOrigen.Text = "";
                txtDestino.Text = "";
                dtpVuelo.Value = DateTime.Now;
                txtPasajeros.Text = "";
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtOrigen.Enabled = true;
            txtDestino.Enabled = true;
            dtpVuelo.Enabled = true;
            txtPasajeros.Enabled = true;
            
            txtId.Enabled = false;

            btnAdd.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;

            dgvListado.Enabled = false;
        }
        private void ModoPantallaLectura()
        {
            txtOrigen.Text = "";
            txtDestino.Text = "";
            dtpVuelo.Value = DateTime.Now;
            txtPasajeros.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            btnAdd.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;

            txtOrigen.Enabled = false;
            txtDestino.Enabled = false;
            dtpVuelo.Enabled = false;
            txtPasajeros.Enabled = false;
            txtId.Enabled = false;

            dgvListado.Enabled= true;


        }
        public Vuelo ObtenerInformacion()
        {
            Vuelo v = new Vuelo();

            v.origen = txtOrigen.Text;
            v.destino = txtDestino.Text;
            v.fecha = dtpVuelo.Value;
            if (!String.IsNullOrEmpty(txtPasajeros.Text))
            {
                v.pasajeros = Convert.ToInt32(txtPasajeros.Text);
            }
            

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                v.Id = Convert.ToInt32(txtId.Text);
            }

            return v;
        }
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtOrigen.Text = filaSeleccionada.Cells["Origen"].Value.ToString();
            txtDestino.Text = filaSeleccionada.Cells["Destino"].Value.ToString();
            String columnaFechaSeleccionada = filaSeleccionada.Cells["Fecha"].Value.ToString();
            if(columnaFechaSeleccionada != null && columnaFechaSeleccionada != "")
            {
                dtpVuelo.Value =(DateTime) filaSeleccionada.Cells["Fecha"].Value;
            }
            else
            {
               
            }

           
            
            txtPasajeros.Text = filaSeleccionada.Cells["Pasajeros"].Value.ToString();

        }
        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtOrigen.Text) || String.IsNullOrEmpty(txtDestino.Text) )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

       
    }
}
