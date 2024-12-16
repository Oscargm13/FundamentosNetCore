namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProducto = new TextBox();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(23, 175);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 27);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(23, 243);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(125, 33);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(354, 173);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(94, 29);
            btnSeleccion.TabIndex = 3;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(354, 208);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 29);
            btnTodos.TabIndex = 4;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(672, 173);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(94, 29);
            btnSubir.TabIndex = 5;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(672, 208);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(94, 29);
            btnBajar.TabIndex = 6;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(176, 133);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(146, 244);
            lstTienda.TabIndex = 7;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(474, 133);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(167, 244);
            lstAlmacen.TabIndex = 8;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 110);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Tienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 110);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Almacen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 110);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(23, 142);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 12;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrar;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
    }
}