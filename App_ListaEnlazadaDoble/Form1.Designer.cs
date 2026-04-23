namespace App_ListaEnlazadaDoble
{
    partial class Form1
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
            lblTitulo = new Label();
            lblIngresar = new Label();
            txtNombre = new TextBox();
            btnInsertar = new Button();
            lblIngresa2 = new Label();
            txtEdad = new TextBox();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            listView1 = new ListView();
            CHNombres = new ColumnHeader();
            CHEdades = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(223, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista enlazada doble";
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblIngresar.Location = new Point(105, 106);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(115, 18);
            lblIngresar.TabIndex = 1;
            lblIngresar.Text = "Ingresa nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtNombre.Location = new Point(238, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 24);
            txtNombre.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnInsertar.Location = new Point(148, 164);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(83, 25);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblIngresa2
            // 
            lblIngresa2.AutoSize = true;
            lblIngresa2.Font = new Font("Segoe UI", 11.25F);
            lblIngresa2.Location = new Point(364, 101);
            lblIngresa2.Name = "lblIngresa2";
            lblIngresa2.Size = new Size(98, 20);
            lblIngresa2.TabIndex = 5;
            lblIngresa2.Text = "Ingresa edad:";
            lblIngresa2.Click += label3_Click;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 11.25F);
            txtEdad.Location = new Point(495, 97);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 27);
            txtEdad.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnBuscar.Location = new Point(148, 210);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 25);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnModificar.Location = new Point(148, 255);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(83, 25);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnEliminar.Location = new Point(148, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 25);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CHNombres, CHEdades });
            listView1.Location = new Point(289, 164);
            listView1.Name = "listView1";
            listView1.Size = new Size(284, 193);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CHNombres
            // 
            CHNombres.Text = "NOMBRE";
            CHNombres.Width = 220;
            // 
            // CHEdades
            // 
            CHEdades.Text = "EDAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(txtEdad);
            Controls.Add(lblIngresa2);
            Controls.Add(btnInsertar);
            Controls.Add(txtNombre);
            Controls.Add(lblIngresar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIngresar;
        private TextBox txtNombre;
        private Button btnInsertar;
        private Label lblIngresa2;
        private TextBox txtEdad;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView listView1;
        private ColumnHeader CHNombres;
        private ColumnHeader CHEdades;
    }
}
