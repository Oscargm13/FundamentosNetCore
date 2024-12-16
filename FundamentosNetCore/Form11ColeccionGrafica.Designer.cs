namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            label1 = new Label();
            lstElementos = new ListBox();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            btnInsertar = new Button();
            btnBorrarTodo = new Button();
            btnEleminar = new Button();
            lblSeleccionado = new Label();
            lblSeleccionado2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 68);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(67, 91);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(237, 264);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(597, 111);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(125, 27);
            txtNuevoElemento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(597, 144);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 34);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(597, 226);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(125, 39);
            btnBorrarTodo.TabIndex = 5;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEleminar
            // 
            btnEleminar.Location = new Point(597, 184);
            btnEleminar.Name = "btnEleminar";
            btnEleminar.Size = new Size(125, 36);
            btnEleminar.TabIndex = 6;
            btnEleminar.Text = "Eliminar";
            btnEleminar.UseVisualStyleBackColor = true;
            btnEleminar.Click += button3_Click;
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(67, 358);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(137, 20);
            lblSeleccionado.TabIndex = 7;
            lblSeleccionado.Text = "Item selecccionado";
            lblSeleccionado.Click += label3_Click;
            // 
            // lblSeleccionado2
            // 
            lblSeleccionado2.AutoSize = true;
            lblSeleccionado2.Location = new Point(67, 378);
            lblSeleccionado2.Name = "lblSeleccionado2";
            lblSeleccionado2.Size = new Size(130, 20);
            lblSeleccionado2.TabIndex = 8;
            lblSeleccionado2.Text = "Item seleccionado";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeleccionado2);
            Controls.Add(lblSeleccionado);
            Controls.Add(btnEleminar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnInsertar);
            Controls.Add(label2);
            Controls.Add(txtNuevoElemento);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Button btnInsertar;
        private Button btnBorrarTodo;
        private Button btnEleminar;
        private Label lblSeleccionado;
        private Label lblSeleccionado2;
    }
}