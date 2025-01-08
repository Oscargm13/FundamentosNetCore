namespace FundamentosNetCore
{
    partial class Form22ClasesMascotas
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            lstMascotas = new ListBox();
            btnNueva = new Button();
            btnLeer = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Mascotas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 122);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(42, 145);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 4;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(283, 75);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(227, 304);
            lstMascotas.TabIndex = 5;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(42, 188);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(125, 51);
            btnNueva.TabIndex = 6;
            btnNueva.Text = "Nueva mascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(42, 258);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(125, 49);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer mascotas";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(42, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 61);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form22ClasesMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(btnNueva);
            Controls.Add(lstMascotas);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form22ClasesMascotas";
            Text = "Form22ClasesMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private ListBox lstMascotas;
        private Button btnNueva;
        private Button btnLeer;
        private Button btnGuardar;
    }
}