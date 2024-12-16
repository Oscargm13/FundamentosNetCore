namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblSeleccionado2 = new Label();
            lblSeleccionado = new Label();
            btnEleminar = new Button();
            btnBorrarTodo = new Button();
            btnInsertar = new Button();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblSeleccionado2
            // 
            lblSeleccionado2.AutoSize = true;
            lblSeleccionado2.Location = new Point(73, 370);
            lblSeleccionado2.Name = "lblSeleccionado2";
            lblSeleccionado2.Size = new Size(130, 20);
            lblSeleccionado2.TabIndex = 17;
            lblSeleccionado2.Text = "Item seleccionado";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(73, 350);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(137, 20);
            lblSeleccionado.TabIndex = 16;
            lblSeleccionado.Text = "Item selecccionado";
            // 
            // btnEleminar
            // 
            btnEleminar.Location = new Point(603, 176);
            btnEleminar.Name = "btnEleminar";
            btnEleminar.Size = new Size(125, 36);
            btnEleminar.TabIndex = 15;
            btnEleminar.Text = "Eliminar";
            btnEleminar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(603, 218);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(125, 39);
            btnBorrarTodo.TabIndex = 14;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(603, 136);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 34);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 66);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(603, 103);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(125, 27);
            txtNuevoElemento.TabIndex = 11;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(73, 83);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(237, 264);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(603, 263);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(125, 37);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblSeleccionado2);
            Controls.Add(lblSeleccionado);
            Controls.Add(btnEleminar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnInsertar);
            Controls.Add(label2);
            Controls.Add(txtNuevoElemento);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeleccionado2;
        private Label lblSeleccionado;
        private Button btnEleminar;
        private Button btnBorrarTodo;
        private Button btnInsertar;
        private Label label2;
        private TextBox txtNuevoElemento;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}