namespace WinFormsApp
{
    partial class frmVuelos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInfoContacto = new System.Windows.Forms.GroupBox();
            this.dtpVuelo = new System.Windows.Forms.DateTimePicker();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.gbInfoContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoContacto
            // 
            this.gbInfoContacto.Controls.Add(this.dtpVuelo);
            this.gbInfoContacto.Controls.Add(this.txtPasajeros);
            this.gbInfoContacto.Controls.Add(this.txtDestino);
            this.gbInfoContacto.Controls.Add(this.txtOrigen);
            this.gbInfoContacto.Controls.Add(this.txtId);
            this.gbInfoContacto.Controls.Add(this.lblPasajeros);
            this.gbInfoContacto.Controls.Add(this.lblFecha);
            this.gbInfoContacto.Controls.Add(this.lblDestino);
            this.gbInfoContacto.Controls.Add(this.lblOrigen);
            this.gbInfoContacto.Controls.Add(this.lblId);
            this.gbInfoContacto.Location = new System.Drawing.Point(52, 26);
            this.gbInfoContacto.Name = "gbInfoContacto";
            this.gbInfoContacto.Size = new System.Drawing.Size(1002, 264);
            this.gbInfoContacto.TabIndex = 0;
            this.gbInfoContacto.TabStop = false;
            this.gbInfoContacto.Text = "Vuelo:";
            // 
            // dtpVuelo
            // 
            this.dtpVuelo.Location = new System.Drawing.Point(201, 159);
            this.dtpVuelo.Name = "dtpVuelo";
            this.dtpVuelo.Size = new System.Drawing.Size(300, 31);
            this.dtpVuelo.TabIndex = 9;
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(201, 196);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(150, 31);
            this.txtPasajeros.TabIndex = 8;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(201, 118);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(150, 31);
            this.txtDestino.TabIndex = 7;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(201, 81);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(150, 31);
            this.txtOrigen.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(201, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 31);
            this.txtId.TabIndex = 5;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(50, 202);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(85, 25);
            this.lblPasajeros.TabIndex = 4;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(50, 162);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 25);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(50, 121);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(77, 25);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(50, 84);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(75, 25);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(50, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(226, 332);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 34);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 34);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(808, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(942, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvListado
            // 

            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(52, 399);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 62;
            this.dgvListado.RowTemplate.Height = 33;
            this.dgvListado.Size = new System.Drawing.Size(1002, 272);
            this.dgvListado.TabIndex = 6;
            this.dgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellClick);
            this.dgvListado.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListado_RowStateChanged);
            // 
            // frmVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 715);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbInfoContacto);
            this.Name = "frmVuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.frmVuelos_Load);
            this.gbInfoContacto.ResumeLayout(false);
            this.gbInfoContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbInfoContacto;
        private DateTimePicker dtpVuelo;
        private TextBox txtPasajeros;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private TextBox txtId;
        private Label lblPasajeros;
        private Label lblFecha;
        private Label lblDestino;
        private Label lblOrigen;
        private Label lblId;
        private Button btnAdd;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvListado;
    }
}